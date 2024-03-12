namespace Lrt_Ilukste
{
    partial class FormOptions
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonSaveConfiguration = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.radioButtonDB = new System.Windows.Forms.RadioButton();
            this.radioButtonOPC = new System.Windows.Forms.RadioButton();
            this.checkBoxAutoSaabRead = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxSaabTimeIntervalDB = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSaabTimeInterval = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ButtonSaveCalibration = new System.Windows.Forms.Button();
            this.ButtonReadFile = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTank = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.buttonChangeUser = new System.Windows.Forms.Button();
            this.buttonNewUser = new System.Windows.Forms.Button();
            this.radioButtonAccessAdmininistrator = new System.Windows.Forms.RadioButton();
            this.radioButtonAccessDispatcher = new System.Windows.Forms.RadioButton();
            this.radioButtonAccessOperator = new System.Windows.Forms.RadioButton();
            this.radioButtonAccessPartner = new System.Windows.Forms.RadioButton();
            this.radioButtonaAccessNo = new System.Windows.Forms.RadioButton();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBoxActivity = new System.Windows.Forms.CheckBox();
            this.buttonChangePartner = new System.Windows.Forms.Button();
            this.buttonNewPartner = new System.Windows.Forms.Button();
            this.textBoxPersonSurname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxPersonName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView6 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxPartnerName = new System.Windows.Forms.ComboBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(18, 20);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(670, 539);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonSaveConfiguration);
            this.tabPage1.Controls.Add(this.ButtonCreate);
            this.tabPage1.Controls.Add(this.textBoxConnectionString);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(662, 508);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Конфигурация";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonSaveConfiguration
            // 
            this.buttonSaveConfiguration.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSaveConfiguration.Location = new System.Drawing.Point(540, 282);
            this.buttonSaveConfiguration.Name = "buttonSaveConfiguration";
            this.buttonSaveConfiguration.Size = new System.Drawing.Size(115, 30);
            this.buttonSaveConfiguration.TabIndex = 23;
            this.buttonSaveConfiguration.Text = "Сохранить";
            this.buttonSaveConfiguration.UseVisualStyleBackColor = true;
            this.buttonSaveConfiguration.Click += new System.EventHandler(this.buttonSaveConfiguration_Click);
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Location = new System.Drawing.Point(540, 237);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(115, 30);
            this.ButtonCreate.TabIndex = 22;
            this.ButtonCreate.Text = "Создать";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(7, 240);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.Size = new System.Drawing.Size(511, 24);
            this.textBoxConnectionString.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 219);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(325, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Строка подключения к базе данных отчётов:";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.radioButtonDB);
            this.groupBox6.Controls.Add(this.radioButtonOPC);
            this.groupBox6.Controls.Add(this.checkBoxAutoSaabRead);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.textBoxSaabTimeIntervalDB);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label1);
            this.groupBox6.Controls.Add(this.textBoxSaabTimeInterval);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.groupBox6.Location = new System.Drawing.Point(7, 7);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(648, 195);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Текущие данные";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 57);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(194, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "Источник текущих данных:";
            // 
            // radioButtonDB
            // 
            this.radioButtonDB.AutoSize = true;
            this.radioButtonDB.Location = new System.Drawing.Point(127, 78);
            this.radioButtonDB.Name = "radioButtonDB";
            this.radioButtonDB.Size = new System.Drawing.Size(115, 22);
            this.radioButtonDB.TabIndex = 15;
            this.radioButtonDB.Text = "База данных";
            this.radioButtonDB.UseVisualStyleBackColor = true;
            // 
            // radioButtonOPC
            // 
            this.radioButtonOPC.AutoSize = true;
            this.radioButtonOPC.Location = new System.Drawing.Point(10, 78);
            this.radioButtonOPC.Name = "radioButtonOPC";
            this.radioButtonOPC.Size = new System.Drawing.Size(111, 22);
            this.radioButtonOPC.TabIndex = 14;
            this.radioButtonOPC.Text = "OPC сервер";
            this.radioButtonOPC.UseVisualStyleBackColor = true;
            // 
            // checkBoxAutoSaabRead
            // 
            this.checkBoxAutoSaabRead.AutoSize = true;
            this.checkBoxAutoSaabRead.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAutoSaabRead.Location = new System.Drawing.Point(6, 23);
            this.checkBoxAutoSaabRead.Name = "checkBoxAutoSaabRead";
            this.checkBoxAutoSaabRead.Size = new System.Drawing.Size(284, 22);
            this.checkBoxAutoSaabRead.TabIndex = 13;
            this.checkBoxAutoSaabRead.Text = "Автоматическое считывание данных";
            this.checkBoxAutoSaabRead.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAutoSaabRead.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(330, 148);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "секунд";
            // 
            // textBoxSaabTimeIntervalDB
            // 
            this.textBoxSaabTimeIntervalDB.Location = new System.Drawing.Point(275, 145);
            this.textBoxSaabTimeIntervalDB.Name = "textBoxSaabTimeIntervalDB";
            this.textBoxSaabTimeIntervalDB.Size = new System.Drawing.Size(43, 24);
            this.textBoxSaabTimeIntervalDB.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 148);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(223, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Интервал записи в DB данных:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "секунд";
            // 
            // textBoxSaabTimeInterval
            // 
            this.textBoxSaabTimeInterval.Location = new System.Drawing.Point(275, 108);
            this.textBoxSaabTimeInterval.Name = "textBoxSaabTimeInterval";
            this.textBoxSaabTimeInterval.Size = new System.Drawing.Size(43, 24);
            this.textBoxSaabTimeInterval.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Интервал считывания данных:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView4);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.ButtonSaveCalibration);
            this.tabPage2.Controls.Add(this.ButtonReadFile);
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.comboBoxTank);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(662, 508);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Калибровка";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AllowUserToAddRows = false;
            this.dataGridView4.AllowUserToDeleteRows = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(342, 284);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.Size = new System.Drawing.Size(300, 217);
            this.dataGridView4.TabIndex = 25;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 284);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(300, 217);
            this.dataGridView2.TabIndex = 24;
            // 
            // ButtonSaveCalibration
            // 
            this.ButtonSaveCalibration.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonSaveCalibration.Location = new System.Drawing.Point(527, 12);
            this.ButtonSaveCalibration.Name = "ButtonSaveCalibration";
            this.ButtonSaveCalibration.Size = new System.Drawing.Size(115, 30);
            this.ButtonSaveCalibration.TabIndex = 12;
            this.ButtonSaveCalibration.Text = "Сохранить";
            this.ButtonSaveCalibration.UseVisualStyleBackColor = true;
            this.ButtonSaveCalibration.Click += new System.EventHandler(this.ButtonSaveCalibration_Click);
            // 
            // ButtonReadFile
            // 
            this.ButtonReadFile.Location = new System.Drawing.Point(387, 13);
            this.ButtonReadFile.Name = "ButtonReadFile";
            this.ButtonReadFile.Size = new System.Drawing.Size(134, 30);
            this.ButtonReadFile.TabIndex = 23;
            this.ButtonReadFile.Text = "Читать из файла";
            this.ButtonReadFile.UseVisualStyleBackColor = true;
            this.ButtonReadFile.Click += new System.EventHandler(this.ButtonReadFile_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(342, 48);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(300, 217);
            this.dataGridView3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(300, 217);
            this.dataGridView1.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Резервуар";
            // 
            // comboBoxTank
            // 
            this.comboBoxTank.FormattingEnabled = true;
            this.comboBoxTank.Location = new System.Drawing.Point(103, 16);
            this.comboBoxTank.Name = "comboBoxTank";
            this.comboBoxTank.Size = new System.Drawing.Size(60, 26);
            this.comboBoxTank.TabIndex = 6;
            this.comboBoxTank.SelectedIndexChanged += new System.EventHandler(this.comboBoxTank_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDeleteUser);
            this.tabPage3.Controls.Add(this.buttonChangeUser);
            this.tabPage3.Controls.Add(this.buttonNewUser);
            this.tabPage3.Controls.Add(this.radioButtonAccessAdmininistrator);
            this.tabPage3.Controls.Add(this.radioButtonAccessDispatcher);
            this.tabPage3.Controls.Add(this.radioButtonAccessOperator);
            this.tabPage3.Controls.Add(this.radioButtonAccessPartner);
            this.tabPage3.Controls.Add(this.radioButtonaAccessNo);
            this.tabPage3.Controls.Add(this.textBoxPassword);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.textBoxUserName);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.dataGridView5);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(662, 508);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Пользователи";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonDeleteUser.Location = new System.Drawing.Point(538, 272);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(90, 30);
            this.buttonDeleteUser.TabIndex = 22;
            this.buttonDeleteUser.Text = "Удалить";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // buttonChangeUser
            // 
            this.buttonChangeUser.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonChangeUser.Location = new System.Drawing.Point(442, 272);
            this.buttonChangeUser.Name = "buttonChangeUser";
            this.buttonChangeUser.Size = new System.Drawing.Size(90, 30);
            this.buttonChangeUser.TabIndex = 21;
            this.buttonChangeUser.Text = "Изменить";
            this.buttonChangeUser.UseVisualStyleBackColor = true;
            this.buttonChangeUser.Click += new System.EventHandler(this.buttonChangeUser_Click);
            // 
            // buttonNewUser
            // 
            this.buttonNewUser.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonNewUser.Location = new System.Drawing.Point(346, 272);
            this.buttonNewUser.Name = "buttonNewUser";
            this.buttonNewUser.Size = new System.Drawing.Size(90, 30);
            this.buttonNewUser.TabIndex = 20;
            this.buttonNewUser.Text = "Новый";
            this.buttonNewUser.UseVisualStyleBackColor = true;
            this.buttonNewUser.Click += new System.EventHandler(this.buttonNewUser_Click);
            // 
            // radioButtonAccessAdmininistrator
            // 
            this.radioButtonAccessAdmininistrator.AutoSize = true;
            this.radioButtonAccessAdmininistrator.Location = new System.Drawing.Point(389, 234);
            this.radioButtonAccessAdmininistrator.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAccessAdmininistrator.Name = "radioButtonAccessAdmininistrator";
            this.radioButtonAccessAdmininistrator.Size = new System.Drawing.Size(134, 22);
            this.radioButtonAccessAdmininistrator.TabIndex = 18;
            this.radioButtonAccessAdmininistrator.Text = "Администратор";
            this.radioButtonAccessAdmininistrator.UseVisualStyleBackColor = true;
            // 
            // radioButtonAccessDispatcher
            // 
            this.radioButtonAccessDispatcher.AutoSize = true;
            this.radioButtonAccessDispatcher.Location = new System.Drawing.Point(389, 204);
            this.radioButtonAccessDispatcher.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAccessDispatcher.Name = "radioButtonAccessDispatcher";
            this.radioButtonAccessDispatcher.Size = new System.Drawing.Size(101, 22);
            this.radioButtonAccessDispatcher.TabIndex = 17;
            this.radioButtonAccessDispatcher.Text = "Диспетчер";
            this.radioButtonAccessDispatcher.UseVisualStyleBackColor = true;
            // 
            // radioButtonAccessOperator
            // 
            this.radioButtonAccessOperator.AutoSize = true;
            this.radioButtonAccessOperator.Location = new System.Drawing.Point(389, 174);
            this.radioButtonAccessOperator.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAccessOperator.Name = "radioButtonAccessOperator";
            this.radioButtonAccessOperator.Size = new System.Drawing.Size(94, 22);
            this.radioButtonAccessOperator.TabIndex = 16;
            this.radioButtonAccessOperator.Text = "Оператор";
            this.radioButtonAccessOperator.UseVisualStyleBackColor = true;
            // 
            // radioButtonAccessPartner
            // 
            this.radioButtonAccessPartner.AutoSize = true;
            this.radioButtonAccessPartner.Location = new System.Drawing.Point(389, 144);
            this.radioButtonAccessPartner.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonAccessPartner.Name = "radioButtonAccessPartner";
            this.radioButtonAccessPartner.Size = new System.Drawing.Size(84, 22);
            this.radioButtonAccessPartner.TabIndex = 15;
            this.radioButtonAccessPartner.Text = "Партнёр";
            this.radioButtonAccessPartner.UseVisualStyleBackColor = true;
            // 
            // radioButtonaAccessNo
            // 
            this.radioButtonaAccessNo.AutoSize = true;
            this.radioButtonaAccessNo.Checked = true;
            this.radioButtonaAccessNo.Location = new System.Drawing.Point(389, 114);
            this.radioButtonaAccessNo.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonaAccessNo.Name = "radioButtonaAccessNo";
            this.radioButtonaAccessNo.Size = new System.Drawing.Size(112, 22);
            this.radioButtonaAccessNo.TabIndex = 14;
            this.radioButtonaAccessNo.TabStop = true;
            this.radioButtonaAccessNo.Text = "Нет доступа";
            this.radioButtonaAccessNo.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(389, 72);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(217, 24);
            this.textBoxPassword.TabIndex = 13;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Пароль:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(389, 33);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(217, 24);
            this.textBoxUserName.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(247, 36);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Имя пользователя:";
            // 
            // dataGridView5
            // 
            this.dataGridView5.AllowUserToAddRows = false;
            this.dataGridView5.AllowUserToDeleteRows = false;
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(17, 33);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.ReadOnly = true;
            this.dataGridView5.Size = new System.Drawing.Size(220, 454);
            this.dataGridView5.TabIndex = 9;
            this.dataGridView5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView5_CellContentClick);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBoxActivity);
            this.tabPage4.Controls.Add(this.buttonChangePartner);
            this.tabPage4.Controls.Add(this.buttonNewPartner);
            this.tabPage4.Controls.Add(this.textBoxPersonSurname);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.textBoxPersonName);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.dataGridView6);
            this.tabPage4.Controls.Add(this.label7);
            this.tabPage4.Controls.Add(this.comboBoxPartnerName);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(662, 508);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ответственные";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBoxActivity
            // 
            this.checkBoxActivity.AutoSize = true;
            this.checkBoxActivity.Location = new System.Drawing.Point(466, 133);
            this.checkBoxActivity.Name = "checkBoxActivity";
            this.checkBoxActivity.Size = new System.Drawing.Size(153, 22);
            this.checkBoxActivity.TabIndex = 20;
            this.checkBoxActivity.Text = "Активный партнёр";
            this.checkBoxActivity.UseVisualStyleBackColor = true;
            // 
            // buttonChangePartner
            // 
            this.buttonChangePartner.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonChangePartner.Location = new System.Drawing.Point(557, 179);
            this.buttonChangePartner.Name = "buttonChangePartner";
            this.buttonChangePartner.Size = new System.Drawing.Size(90, 30);
            this.buttonChangePartner.TabIndex = 19;
            this.buttonChangePartner.Text = "Изменить";
            this.buttonChangePartner.UseVisualStyleBackColor = true;
            this.buttonChangePartner.Click += new System.EventHandler(this.buttonChangePartner_Click);
            // 
            // buttonNewPartner
            // 
            this.buttonNewPartner.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonNewPartner.Location = new System.Drawing.Point(465, 179);
            this.buttonNewPartner.Name = "buttonNewPartner";
            this.buttonNewPartner.Size = new System.Drawing.Size(90, 30);
            this.buttonNewPartner.TabIndex = 18;
            this.buttonNewPartner.Text = "Новый";
            this.buttonNewPartner.UseVisualStyleBackColor = true;
            this.buttonNewPartner.Click += new System.EventHandler(this.buttonNewPartner_Click);
            // 
            // textBoxPersonSurname
            // 
            this.textBoxPersonSurname.Location = new System.Drawing.Point(466, 93);
            this.textBoxPersonSurname.Name = "textBoxPersonSurname";
            this.textBoxPersonSurname.Size = new System.Drawing.Size(181, 24);
            this.textBoxPersonSurname.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 93);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Фамилия:";
            // 
            // textBoxPersonName
            // 
            this.textBoxPersonName.Location = new System.Drawing.Point(466, 59);
            this.textBoxPersonName.Name = "textBoxPersonName";
            this.textBoxPersonName.Size = new System.Drawing.Size(181, 24);
            this.textBoxPersonName.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(417, 62);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 18);
            this.label8.TabIndex = 13;
            this.label8.Text = "Имя:";
            // 
            // dataGridView6
            // 
            this.dataGridView6.AllowUserToAddRows = false;
            this.dataGridView6.AllowUserToDeleteRows = false;
            this.dataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView6.Location = new System.Drawing.Point(16, 62);
            this.dataGridView6.Name = "dataGridView6";
            this.dataGridView6.ReadOnly = true;
            this.dataGridView6.Size = new System.Drawing.Size(359, 422);
            this.dataGridView6.TabIndex = 12;
            this.dataGridView6.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView6_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 11;
            this.label7.Text = "Организация:";
            // 
            // comboBoxPartnerName
            // 
            this.comboBoxPartnerName.FormattingEnabled = true;
            this.comboBoxPartnerName.Location = new System.Drawing.Point(122, 17);
            this.comboBoxPartnerName.Name = "comboBoxPartnerName";
            this.comboBoxPartnerName.Size = new System.Drawing.Size(253, 26);
            this.comboBoxPartnerName.TabIndex = 1;
            this.comboBoxPartnerName.SelectedIndexChanged += new System.EventHandler(this.comboBoxPartnerName_SelectedIndexChanged);
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Location = new System.Drawing.Point(569, 563);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(115, 30);
            this.ButtonExit.TabIndex = 13;
            this.ButtonExit.Text = "Отменить";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 599);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.ButtonExit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOptions";
            this.Text = "Конфигурация программы";
            this.Load += new System.EventHandler(this.FormOptions_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSaabTimeInterval;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTank;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonSaveCalibration;
        private System.Windows.Forms.Button ButtonReadFile;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButtonAccessAdmininistrator;
        private System.Windows.Forms.RadioButton radioButtonAccessDispatcher;
        private System.Windows.Forms.RadioButton radioButtonAccessOperator;
        private System.Windows.Forms.RadioButton radioButtonAccessPartner;
        private System.Windows.Forms.RadioButton radioButtonaAccessNo;
        private System.Windows.Forms.DataGridView dataGridView6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxPartnerName;
        private System.Windows.Forms.TextBox textBoxPersonSurname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxPersonName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonNewPartner;
        private System.Windows.Forms.Button buttonChangePartner;
        private System.Windows.Forms.Button buttonChangeUser;
        private System.Windows.Forms.Button buttonNewUser;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.CheckBox checkBoxActivity;
        private System.Windows.Forms.Button buttonSaveConfiguration;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxSaabTimeIntervalDB;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox checkBoxAutoSaabRead;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton radioButtonDB;
        private System.Windows.Forms.RadioButton radioButtonOPC;
    }
}