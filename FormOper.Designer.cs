namespace Lrt_Ilukste
{
    partial class FormOper
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
            this.components = new System.ComponentModel.Container();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSeconds = new System.Windows.Forms.Label();
            this.textBoxSaabReadCounter = new System.Windows.Forms.TextBox();
            this.labelSaabRead = new System.Windows.Forms.Label();
            this.buttonSaabData = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSeconds);
            this.groupBox2.Controls.Add(this.textBoxSaabReadCounter);
            this.groupBox2.Controls.Add(this.labelSaabRead);
            this.groupBox2.Controls.Add(this.buttonSaabData);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(810, 81);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительные параметры";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(455, 42);
            this.labelSeconds.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(56, 18);
            this.labelSeconds.TabIndex = 27;
            this.labelSeconds.Text = "секунд";
            this.labelSeconds.Visible = false;
            // 
            // textBoxSaabReadCounter
            // 
            this.textBoxSaabReadCounter.Enabled = false;
            this.textBoxSaabReadCounter.Location = new System.Drawing.Point(405, 39);
            this.textBoxSaabReadCounter.Name = "textBoxSaabReadCounter";
            this.textBoxSaabReadCounter.Size = new System.Drawing.Size(43, 24);
            this.textBoxSaabReadCounter.TabIndex = 26;
            this.textBoxSaabReadCounter.Visible = false;
            // 
            // labelSaabRead
            // 
            this.labelSaabRead.AutoSize = true;
            this.labelSaabRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.labelSaabRead.Location = new System.Drawing.Point(7, 42);
            this.labelSaabRead.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSaabRead.Name = "labelSaabRead";
            this.labelSaabRead.Size = new System.Drawing.Size(206, 18);
            this.labelSaabRead.TabIndex = 25;
            this.labelSaabRead.Text = "Считывание данных с Saab: ";
            // 
            // buttonSaabData
            // 
            this.buttonSaabData.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSaabData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.buttonSaabData.Location = new System.Drawing.Point(609, 33);
            this.buttonSaabData.Name = "buttonSaabData";
            this.buttonSaabData.Size = new System.Drawing.Size(189, 30);
            this.buttonSaabData.TabIndex = 24;
            this.buttonSaabData.Text = "Получить данные с Saab";
            this.buttonSaabData.UseVisualStyleBackColor = true;
            this.buttonSaabData.Visible = false;
            this.buttonSaabData.Click += new System.EventHandler(this.buttonSaabData_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(789, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridView1);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.groupBox6.Location = new System.Drawing.Point(12, 116);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(813, 474);
            this.groupBox6.TabIndex = 18;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Текущие данные";
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ButtonExit.Location = new System.Drawing.Point(710, 596);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(115, 30);
            this.ButtonExit.TabIndex = 20;
            this.ButtonExit.Text = "Выйти";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormOper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 641);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOper";
            this.Text = "Текущие данные с SaabTank Radar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormOper_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button buttonSaabData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelSaabRead;
        private System.Windows.Forms.Label labelSeconds;
        private System.Windows.Forms.TextBox textBoxSaabReadCounter;
    }
}