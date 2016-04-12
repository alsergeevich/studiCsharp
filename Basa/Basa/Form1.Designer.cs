namespace Basa
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNameBase = new System.Windows.Forms.TextBox();
            this.txtPassw = new System.Windows.Forms.TextBox();
            this.txtNameTab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnGetTab = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNameServer = new System.Windows.Forms.TextBox();
            this.btnShowTables = new System.Windows.Forms.Button();
            this.btnConBasa = new System.Windows.Forms.Button();
            this.btnCloseBase = new System.Windows.Forms.Button();
            this.lblCon = new System.Windows.Forms.Label();
            this.btnShowBase = new System.Windows.Forms.Button();
            this.btnPodkl_k_Base = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFiltr = new System.Windows.Forms.TextBox();
            this.lblFiltr = new System.Windows.Forms.Label();
            this.txtNameColumns = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnFiltr = new System.Windows.Forms.Button();
            this.txtStobci = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.radbtnSel1 = new System.Windows.Forms.RadioButton();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.radbtnSel2 = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnExpToExel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(122, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(171, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtNameBase
            // 
            this.txtNameBase.Location = new System.Drawing.Point(122, 154);
            this.txtNameBase.Name = "txtNameBase";
            this.txtNameBase.Size = new System.Drawing.Size(171, 20);
            this.txtNameBase.TabIndex = 3;
            // 
            // txtPassw
            // 
            this.txtPassw.Location = new System.Drawing.Point(122, 40);
            this.txtPassw.Name = "txtPassw";
            this.txtPassw.PasswordChar = '*';
            this.txtPassw.Size = new System.Drawing.Size(171, 20);
            this.txtPassw.TabIndex = 1;
            this.txtPassw.UseSystemPasswordChar = true;
            // 
            // txtNameTab
            // 
            this.txtNameTab.Location = new System.Drawing.Point(122, 251);
            this.txtNameTab.Name = "txtNameTab";
            this.txtNameTab.Size = new System.Drawing.Size(171, 20);
            this.txtNameTab.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Имя базы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Имя таблицы";
            // 
            // btnGetTab
            // 
            this.btnGetTab.Location = new System.Drawing.Point(318, 240);
            this.btnGetTab.Name = "btnGetTab";
            this.btnGetTab.Size = new System.Drawing.Size(166, 31);
            this.btnGetTab.TabIndex = 8;
            this.btnGetTab.Text = "Вывести таблицу";
            this.btnGetTab.UseVisualStyleBackColor = true;
            this.btnGetTab.Click += new System.EventHandler(this.btnGetTab_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1283, 325);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Имя сервера";
            // 
            // txtNameServer
            // 
            this.txtNameServer.Location = new System.Drawing.Point(122, 69);
            this.txtNameServer.Name = "txtNameServer";
            this.txtNameServer.Size = new System.Drawing.Size(171, 20);
            this.txtNameServer.TabIndex = 2;
            // 
            // btnShowTables
            // 
            this.btnShowTables.Location = new System.Drawing.Point(122, 193);
            this.btnShowTables.Name = "btnShowTables";
            this.btnShowTables.Size = new System.Drawing.Size(171, 40);
            this.btnShowTables.TabIndex = 12;
            this.btnShowTables.Text = "Показать список всех доступных таблиц";
            this.btnShowTables.UseVisualStyleBackColor = true;
            this.btnShowTables.Click += new System.EventHandler(this.btnShowTables_Click);
            // 
            // btnConBasa
            // 
            this.btnConBasa.Location = new System.Drawing.Point(318, 12);
            this.btnConBasa.Name = "btnConBasa";
            this.btnConBasa.Size = new System.Drawing.Size(166, 34);
            this.btnConBasa.TabIndex = 13;
            this.btnConBasa.Text = "Подключиться к MySql";
            this.btnConBasa.UseVisualStyleBackColor = true;
            this.btnConBasa.Click += new System.EventHandler(this.btnConBasa_Click);
            // 
            // btnCloseBase
            // 
            this.btnCloseBase.Location = new System.Drawing.Point(318, 54);
            this.btnCloseBase.Name = "btnCloseBase";
            this.btnCloseBase.Size = new System.Drawing.Size(166, 35);
            this.btnCloseBase.TabIndex = 14;
            this.btnCloseBase.Text = "Отключится от MySql";
            this.btnCloseBase.UseVisualStyleBackColor = true;
            this.btnCloseBase.Click += new System.EventHandler(this.btnCloseBase_Click);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCon.Location = new System.Drawing.Point(503, 36);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(239, 24);
            this.lblCon.TabIndex = 15;
            this.lblCon.Text = "Соединение отсутствует";
            // 
            // btnShowBase
            // 
            this.btnShowBase.Location = new System.Drawing.Point(122, 95);
            this.btnShowBase.Name = "btnShowBase";
            this.btnShowBase.Size = new System.Drawing.Size(171, 43);
            this.btnShowBase.TabIndex = 16;
            this.btnShowBase.Text = "Показать список всех доступных баз";
            this.btnShowBase.UseVisualStyleBackColor = true;
            this.btnShowBase.Click += new System.EventHandler(this.btnShowBase_Click);
            // 
            // btnPodkl_k_Base
            // 
            this.btnPodkl_k_Base.Location = new System.Drawing.Point(318, 154);
            this.btnPodkl_k_Base.Name = "btnPodkl_k_Base";
            this.btnPodkl_k_Base.Size = new System.Drawing.Size(166, 23);
            this.btnPodkl_k_Base.TabIndex = 17;
            this.btnPodkl_k_Base.Text = "подключиться к базе";
            this.btnPodkl_k_Base.UseVisualStyleBackColor = true;
            this.btnPodkl_k_Base.Click += new System.EventHandler(this.btnPodkl_k_Base_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Если не знаешь имя БД, жми сюда.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(318, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Если не знаешь имя таблицы, жми сюда.";
            // 
            // txtFiltr
            // 
            this.txtFiltr.Location = new System.Drawing.Point(621, 175);
            this.txtFiltr.Name = "txtFiltr";
            this.txtFiltr.Size = new System.Drawing.Size(148, 20);
            this.txtFiltr.TabIndex = 20;
            // 
            // lblFiltr
            // 
            this.lblFiltr.AutoSize = true;
            this.lblFiltr.Location = new System.Drawing.Point(788, 182);
            this.lblFiltr.Name = "lblFiltr";
            this.lblFiltr.Size = new System.Drawing.Size(355, 13);
            this.lblFiltr.TabIndex = 21;
            this.lblFiltr.Text = "Фильтр. Для фильтра используйте % и _. Например %1_1% или 11%";
            // 
            // txtNameColumns
            // 
            this.txtNameColumns.Location = new System.Drawing.Point(618, 138);
            this.txtNameColumns.Name = "txtNameColumns";
            this.txtNameColumns.Size = new System.Drawing.Size(148, 20);
            this.txtNameColumns.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(788, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Имя столбца для фильтра";
            // 
            // btnFiltr
            // 
            this.btnFiltr.Location = new System.Drawing.Point(621, 245);
            this.btnFiltr.Name = "btnFiltr";
            this.btnFiltr.Size = new System.Drawing.Size(148, 23);
            this.btnFiltr.TabIndex = 24;
            this.btnFiltr.Text = "Отфильтровать";
            this.btnFiltr.UseVisualStyleBackColor = true;
            this.btnFiltr.Click += new System.EventHandler(this.btnFiltr_Click);
            // 
            // txtStobci
            // 
            this.txtStobci.Location = new System.Drawing.Point(618, 100);
            this.txtStobci.Name = "txtStobci";
            this.txtStobci.Size = new System.Drawing.Size(148, 20);
            this.txtStobci.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(788, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(291, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Столбцы для вывода через запятую. Для вывода всех *";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(788, 15);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(0, 13);
            this.lblTest.TabIndex = 27;
            // 
            // radbtnSel1
            // 
            this.radbtnSel1.AutoSize = true;
            this.radbtnSel1.Location = new System.Drawing.Point(576, 175);
            this.radbtnSel1.Name = "radbtnSel1";
            this.radbtnSel1.Size = new System.Drawing.Size(14, 13);
            this.radbtnSel1.TabIndex = 28;
            this.radbtnSel1.UseVisualStyleBackColor = true;
            // 
            // txtData1
            // 
            this.txtData1.Location = new System.Drawing.Point(621, 207);
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(101, 20);
            this.txtData1.TabIndex = 29;
            // 
            // txtData2
            // 
            this.txtData2.Location = new System.Drawing.Point(764, 207);
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(102, 20);
            this.txtData2.TabIndex = 30;
            // 
            // radbtnSel2
            // 
            this.radbtnSel2.AutoSize = true;
            this.radbtnSel2.Location = new System.Drawing.Point(576, 207);
            this.radbtnSel2.Name = "radbtnSel2";
            this.radbtnSel2.Size = new System.Drawing.Size(14, 13);
            this.radbtnSel2.TabIndex = 31;
            this.radbtnSel2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(872, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(422, 13);
            this.label10.TabIndex = 32;
            this.label10.Text = "Фильтр по дате. Формат ввода yyyy-mm-dd. Например, 2016.12.03 или 2016-12-03";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(601, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "С";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(737, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(21, 13);
            this.label12.TabIndex = 34;
            this.label12.Text = "По";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(872, 227);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(369, 13);
            this.label13.TabIndex = 35;
            this.label13.Text = "Если в обоих полях ввести одинаковую дату, результат будет за сутки.";
            // 
            // btnExpToExel
            // 
            this.btnExpToExel.Location = new System.Drawing.Point(1110, 76);
            this.btnExpToExel.Name = "btnExpToExel";
            this.btnExpToExel.Size = new System.Drawing.Size(184, 61);
            this.btnExpToExel.TabIndex = 36;
            this.btnExpToExel.Text = "Экспорт в Excel";
            this.btnExpToExel.UseVisualStyleBackColor = true;
            this.btnExpToExel.Click += new System.EventHandler(this.btnExpToExel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 624);
            this.Controls.Add(this.btnExpToExel);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.radbtnSel2);
            this.Controls.Add(this.txtData2);
            this.Controls.Add(this.txtData1);
            this.Controls.Add(this.radbtnSel1);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStobci);
            this.Controls.Add(this.btnFiltr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNameColumns);
            this.Controls.Add(this.lblFiltr);
            this.Controls.Add(this.txtFiltr);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnPodkl_k_Base);
            this.Controls.Add(this.btnShowBase);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.btnCloseBase);
            this.Controls.Add(this.btnConBasa);
            this.Controls.Add(this.btnShowTables);
            this.Controls.Add(this.txtNameServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnGetTab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameTab);
            this.Controls.Add(this.txtPassw);
            this.Controls.Add(this.txtNameBase);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Работа с БД";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNameBase;
        private System.Windows.Forms.TextBox txtPassw;
        private System.Windows.Forms.TextBox txtNameTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGetTab;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNameServer;
        private System.Windows.Forms.Button btnShowTables;
        private System.Windows.Forms.Button btnConBasa;
        private System.Windows.Forms.Button btnCloseBase;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.Button btnShowBase;
        private System.Windows.Forms.Button btnPodkl_k_Base;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFiltr;
        private System.Windows.Forms.Label lblFiltr;
        private System.Windows.Forms.TextBox txtNameColumns;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnFiltr;
        private System.Windows.Forms.TextBox txtStobci;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.RadioButton radbtnSel1;
        private System.Windows.Forms.TextBox txtData1;
        private System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.RadioButton radbtnSel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnExpToExel;
    }
}

