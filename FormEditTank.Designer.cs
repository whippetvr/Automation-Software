namespace Lrt_Ilukste
{
    partial class FormEditTank
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textBoxLabDensity20 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDensity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAvgTemp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonMeasureRadar = new System.Windows.Forms.RadioButton();
            this.radioButtonMeasureTape = new System.Windows.Forms.RadioButton();
            this.textBoxLevel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxLabMassa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLabVolume20 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCTL20 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCalcVolume = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonCalc = new System.Windows.Forms.Button();
            this.labelelError = new System.Windows.Forms.Label();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.textBoxLabDensity20);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.textBoxDensity);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.textBoxAvgTemp);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.radioButtonMeasureRadar);
            this.groupBox4.Controls.Add(this.radioButtonMeasureTape);
            this.groupBox4.Controls.Add(this.textBoxLevel);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.groupBox4.Location = new System.Drawing.Point(18, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(457, 198);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Данные по резервуару";
            // 
            // textBoxLabDensity20
            // 
            this.textBoxLabDensity20.Location = new System.Drawing.Point(360, 126);
            this.textBoxLabDensity20.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLabDensity20.Name = "textBoxLabDensity20";
            this.textBoxLabDensity20.Size = new System.Drawing.Size(80, 24);
            this.textBoxLabDensity20.TabIndex = 4;
            this.textBoxLabDensity20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLabDensity20_KeyPress);
            this.textBoxLabDensity20.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLabDensity20_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 129);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Плотность ( p20 ) DMA , кг/м3:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxDensity
            // 
            this.textBoxDensity.Location = new System.Drawing.Point(360, 94);
            this.textBoxDensity.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDensity.Name = "textBoxDensity";
            this.textBoxDensity.Size = new System.Drawing.Size(80, 24);
            this.textBoxDensity.TabIndex = 3;
            this.textBoxDensity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDensity_KeyPress);
            this.textBoxDensity.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxDensity_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Плотность ( pi ), кг/м3:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxAvgTemp
            // 
            this.textBoxAvgTemp.Location = new System.Drawing.Point(360, 62);
            this.textBoxAvgTemp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxAvgTemp.Name = "textBoxAvgTemp";
            this.textBoxAvgTemp.Size = new System.Drawing.Size(80, 24);
            this.textBoxAvgTemp.TabIndex = 2;
            this.textBoxAvgTemp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxAvgTemp_KeyPress);
            this.textBoxAvgTemp.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxAvgTemp_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Средняя температура ( ti ), °С :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // radioButtonMeasureRadar
            // 
            this.radioButtonMeasureRadar.AutoSize = true;
            this.radioButtonMeasureRadar.Checked = true;
            this.radioButtonMeasureRadar.Location = new System.Drawing.Point(88, 158);
            this.radioButtonMeasureRadar.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMeasureRadar.Name = "radioButtonMeasureRadar";
            this.radioButtonMeasureRadar.Size = new System.Drawing.Size(169, 22);
            this.radioButtonMeasureRadar.TabIndex = 5;
            this.radioButtonMeasureRadar.TabStop = true;
            this.radioButtonMeasureRadar.Text = "Измерение радаром";
            this.radioButtonMeasureRadar.UseVisualStyleBackColor = true;
            // 
            // radioButtonMeasureTape
            // 
            this.radioButtonMeasureTape.AutoSize = true;
            this.radioButtonMeasureTape.Location = new System.Drawing.Point(265, 158);
            this.radioButtonMeasureTape.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonMeasureTape.Name = "radioButtonMeasureTape";
            this.radioButtonMeasureTape.Size = new System.Drawing.Size(172, 22);
            this.radioButtonMeasureTape.TabIndex = 6;
            this.radioButtonMeasureTape.Text = "Измерение рулеткой";
            this.radioButtonMeasureTape.UseVisualStyleBackColor = true;
            // 
            // textBoxLevel
            // 
            this.textBoxLevel.Location = new System.Drawing.Point(360, 30);
            this.textBoxLevel.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLevel.Name = "textBoxLevel";
            this.textBoxLevel.Size = new System.Drawing.Size(80, 24);
            this.textBoxLevel.TabIndex = 1;
            this.textBoxLevel.Enter += new System.EventHandler(this.textBoxLevel_Enter);
            this.textBoxLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxLevel_KeyPress);
            this.textBoxLevel.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLevel_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Взлив ( Hi ), мм:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxLabMassa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxLabVolume20);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxCTL20);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxCalcVolume);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.groupBox1.Location = new System.Drawing.Point(18, 235);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(457, 251);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Рассчитанные данные";
            // 
            // textBoxLabMassa
            // 
            this.textBoxLabMassa.Location = new System.Drawing.Point(364, 126);
            this.textBoxLabMassa.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLabMassa.Name = "textBoxLabMassa";
            this.textBoxLabMassa.ReadOnly = true;
            this.textBoxLabMassa.Size = new System.Drawing.Size(80, 24);
            this.textBoxLabMassa.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 129);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Масса ДТ, т:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxLabVolume20
            // 
            this.textBoxLabVolume20.Location = new System.Drawing.Point(364, 94);
            this.textBoxLabVolume20.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxLabVolume20.Name = "textBoxLabVolume20";
            this.textBoxLabVolume20.ReadOnly = true;
            this.textBoxLabVolume20.Size = new System.Drawing.Size(80, 24);
            this.textBoxLabVolume20.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 97);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Объём ДТ ( V20 ), м3:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCTL20
            // 
            this.textBoxCTL20.Location = new System.Drawing.Point(364, 62);
            this.textBoxCTL20.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCTL20.Name = "textBoxCTL20";
            this.textBoxCTL20.ReadOnly = true;
            this.textBoxCTL20.Size = new System.Drawing.Size(80, 24);
            this.textBoxCTL20.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(296, 65);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "CTL20 :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBoxCalcVolume
            // 
            this.textBoxCalcVolume.Location = new System.Drawing.Point(364, 30);
            this.textBoxCalcVolume.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCalcVolume.Name = "textBoxCalcVolume";
            this.textBoxCalcVolume.ReadOnly = true;
            this.textBoxCalcVolume.Size = new System.Drawing.Size(80, 24);
            this.textBoxCalcVolume.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 36);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(346, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Объём ДТ при температуре измерения ( Vi ), м3:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ButtonSave
            // 
            this.ButtonSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ButtonSave.Location = new System.Drawing.Point(237, 494);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(115, 30);
            this.ButtonSave.TabIndex = 15;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ButtonExit.Location = new System.Drawing.Point(360, 494);
            this.ButtonExit.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(115, 30);
            this.ButtonExit.TabIndex = 16;
            this.ButtonExit.Text = "Отменить";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonCalc
            // 
            this.ButtonCalc.Enabled = false;
            this.ButtonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.ButtonCalc.Location = new System.Drawing.Point(114, 494);
            this.ButtonCalc.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonCalc.Name = "ButtonCalc";
            this.ButtonCalc.Size = new System.Drawing.Size(115, 30);
            this.ButtonCalc.TabIndex = 17;
            this.ButtonCalc.Text = "Расчёт";
            this.ButtonCalc.UseVisualStyleBackColor = true;
            this.ButtonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // labelelError
            // 
            this.labelelError.AutoSize = true;
            this.labelelError.ForeColor = System.Drawing.Color.Coral;
            this.labelelError.Location = new System.Drawing.Point(180, 9);
            this.labelelError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelelError.Name = "labelelError";
            this.labelelError.Size = new System.Drawing.Size(197, 18);
            this.labelelError.TabIndex = 14;
            this.labelelError.Text = "Ошибка ввода - диапазон: ";
            this.labelelError.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelelError.Visible = false;
            // 
            // Timer1
            // 
            this.Timer1.Enabled = true;
            this.Timer1.Interval = 1000;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FormEditTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 540);
            this.Controls.Add(this.labelelError);
            this.Controls.Add(this.ButtonCalc);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.groupBox4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormEditTank";
            this.Text = "Изменение данных резервуара";
            this.Load += new System.EventHandler(this.FormEditTank_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox textBoxLabDensity20;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDensity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAvgTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonMeasureRadar;
        private System.Windows.Forms.RadioButton radioButtonMeasureTape;
        private System.Windows.Forms.TextBox textBoxLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxLabMassa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxLabVolume20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCTL20;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxCalcVolume;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonCalc;
        private System.Windows.Forms.Label labelelError;
        private System.Windows.Forms.Timer Timer1;
    }
}