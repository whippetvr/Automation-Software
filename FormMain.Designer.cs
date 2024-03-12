namespace Lrt_Ilukste
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemOper = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemReg = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEvent = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemConf = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelUserName = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelOPCState = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemOper,
            this.ToolStripMenuItemReg,
            this.ToolStripMenuItemEvent,
            this.ToolStripMenuItemConf,
            this.ToolStripMenuItemLogin});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemOper
            // 
            this.ToolStripMenuItemOper.Enabled = false;
            this.ToolStripMenuItemOper.Image = global::Lrt_Ilukste.Properties.Resources.NOTE16;
            this.ToolStripMenuItemOper.Name = "ToolStripMenuItemOper";
            this.ToolStripMenuItemOper.Size = new System.Drawing.Size(178, 25);
            this.ToolStripMenuItemOper.Text = "Текущие данные     ";
            this.ToolStripMenuItemOper.Click += new System.EventHandler(this.ToolStripMenuItemOper_Click);
            // 
            // ToolStripMenuItemReg
            // 
            this.ToolStripMenuItemReg.Enabled = false;
            this.ToolStripMenuItemReg.Image = global::Lrt_Ilukste.Properties.Resources.HANDSHAK;
            this.ToolStripMenuItemReg.Name = "ToolStripMenuItemReg";
            this.ToolStripMenuItemReg.Size = new System.Drawing.Size(193, 25);
            this.ToolStripMenuItemReg.Text = "Коммерческий отчёт ";
            this.ToolStripMenuItemReg.Click += new System.EventHandler(this.ToolStripMenuItemReg_Click);
            // 
            // ToolStripMenuItemEvent
            // 
            this.ToolStripMenuItemEvent.Enabled = false;
            this.ToolStripMenuItemEvent.Image = global::Lrt_Ilukste.Properties.Resources.BOOK02;
            this.ToolStripMenuItemEvent.Name = "ToolStripMenuItemEvent";
            this.ToolStripMenuItemEvent.Size = new System.Drawing.Size(179, 25);
            this.ToolStripMenuItemEvent.Text = "Журнал событий     ";
            this.ToolStripMenuItemEvent.Click += new System.EventHandler(this.ToolStripMenuItemEvent_Click);
            // 
            // ToolStripMenuItemConf
            // 
            this.ToolStripMenuItemConf.Enabled = false;
            this.ToolStripMenuItemConf.Image = global::Lrt_Ilukste.Properties.Resources.WRENCH;
            this.ToolStripMenuItemConf.Name = "ToolStripMenuItemConf";
            this.ToolStripMenuItemConf.Size = new System.Drawing.Size(175, 25);
            this.ToolStripMenuItemConf.Text = "Конфигурация        ";
            this.ToolStripMenuItemConf.Click += new System.EventHandler(this.ToolStripMenuItemConf_Click);
            // 
            // ToolStripMenuItemLogin
            // 
            this.ToolStripMenuItemLogin.Image = global::Lrt_Ilukste.Properties.Resources.SECUR08;
            this.ToolStripMenuItemLogin.Name = "ToolStripMenuItemLogin";
            this.ToolStripMenuItemLogin.Size = new System.Drawing.Size(160, 25);
            this.ToolStripMenuItemLogin.Text = "Регистрация        ";
            this.ToolStripMenuItemLogin.Click += new System.EventHandler(this.ToolStripMenuItemLogin_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabelUserName,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabelOPCState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 803);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1200, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(120, 17);
            this.toolStripStatusLabel1.Text = "Пользователь:";
            // 
            // toolStripStatusLabelUserName
            // 
            this.toolStripStatusLabelUserName.AutoSize = false;
            this.toolStripStatusLabelUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.toolStripStatusLabelUserName.Name = "toolStripStatusLabelUserName";
            this.toolStripStatusLabelUserName.Size = new System.Drawing.Size(200, 17);
            this.toolStripStatusLabelUserName.Text = "Нет регистрации";
            this.toolStripStatusLabelUserName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusLabel2.Text = "OPC";
            // 
            // toolStripStatusLabelOPCState
            // 
            this.toolStripStatusLabelOPCState.Name = "toolStripStatusLabelOPCState";
            this.toolStripStatusLabelOPCState.Size = new System.Drawing.Size(57, 17);
            this.toolStripStatusLabelOPCState.Text = "unknown";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 825);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "CКУДТ - система коммерческого учёта дизельного топлива на ЛПДС \"\"Илуксте\"";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOper;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemReg;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemEvent;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemConf;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemLogin;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelUserName;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelOPCState;
    }
}

