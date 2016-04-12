using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Office.Interop.Excel;
using SD = System.Data;
using Excel = Microsoft.Office.Interop.Excel;

namespace Basa
{
    public partial class Form1 : Form
    {
        string Podkl;
        string zapros;
        string zaprosTablic;
        string zaprosBase;
        MySqlConnection mysqlconnect;

        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGetTab_Click(object sender, EventArgs e) //вывести таблицу
        {                                  
            zapros = GetSql();
            Command(zapros);            
      }

        public string GetSql() //формируем запрос на вывод из таблицы
        {
            string zapros = "SELECT* FROM " + txtNameTab.Text;
            return zapros;
        }

        public string GetTablica()//формируем запрос на вывод всех таблиц
        {
            string zaprosTablic = "SHOW TABLES";
            return zaprosTablic;
        }

        public string GetBase()
        {
            string zaprosBase = "SHOW databases";
            return zaprosBase;
        }

        public void Command(string comstr)//метод для отработки запросов, входной параметр это строка запроса
        {
            MySqlCommand mysqlcommand = new MySqlCommand(comstr, mysqlconnect);
            try
            {
                mysqlcommand.ExecuteNonQuery();
                MySqlDataAdapter da = new MySqlDataAdapter(mysqlcommand);
                SD.DataTable dt = new SD.DataTable();                
                da.Fill(dt);
                dataGridView1.Columns.Clear();
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не могу подключиться к базе " + ex.Message);
            }                       
        }

        public void ConnectBD()//метод для подключения к базе данных
        {
            Podkl = "Database=" + txtNameBase.Text + ";" + "Data Source=" + txtNameServer.Text + ";" + "User id=" + txtName.Text + ";" + "Password=" + txtPassw.Text + ";";
            mysqlconnect = new MySqlConnection(Podkl);
            try
            {
                mysqlconnect.Open();
                lblCon.Text = "Соединение установлено";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не могу подключиться к базе " + ex.Message);
                lblCon.Text = "Соединение отсутствует";

            }
        }

        public void ExportToExcel()
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Add();
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                workSheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    workSheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            string pathToFile = Environment.CurrentDirectory + "\\" + "MyFile.xls";
            workSheet.SaveAs(pathToFile);
            exApp.Quit();
            MessageBox.Show("Экспорт завершён");

        }
        

        private void btnShowTables_Click(object sender, EventArgs e)//выводим содержимое таблицы
        {
            zaprosTablic = GetTablica();
            Command(zaprosTablic);

        }

        private void btnConBasa_Click(object sender, EventArgs e)//устанавливаем соединение с БД
        {
            ConnectBD();
        }

        private void btnCloseBase_Click(object sender, EventArgs e)//отключаемся от БД
        {
            
            
                mysqlconnect.Close();
                lblCon.Text = "Соединение отсутствует";
            
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                mysqlconnect.Close();
                lblCon.Text = "Соединение отсутствует";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка данных, отключаюсь от базы  " + ex.Message);
                lblCon.Text = "Соединение отсутствует";

            }

        }

        private void btnShowBase_Click(object sender, EventArgs e)//вывод списка всех доступных баз
        {
            zaprosBase = GetBase();
            Command(zaprosBase);

        }

        private void btnPodkl_k_Base_Click(object sender, EventArgs e)//подключаемся к БД
        {
            ConnectBD();
        }

        private void btnFiltr_Click(object sender, EventArgs e)//фильтруем таблицу
        {
            string stroka = "";
            if (radbtnSel1.Checked == true)
            {
                stroka = string.Format("select {0} from {1} where {2} like '{3}'", txtStobci.Text, txtNameTab.Text, txtNameColumns.Text, txtFiltr.Text);//формируем строку запроса с фильтром
            }

            if (radbtnSel2.Checked == true)
            {
                stroka = string.Format("select {0} from {1} where {2} between '{3} 00:00:00' and '{4} 23:59:59'", txtStobci.Text, txtNameTab.Text, txtNameColumns.Text, txtData1.Text, txtData2.Text);
            }
            //lblTest.Text = stroka;
            Command(stroka);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radbtnSel1.Checked = true;
        }

        private void btnExpToExel_Click(object sender, EventArgs e)
        {
            ExportToExcel();
        }
    }
}
