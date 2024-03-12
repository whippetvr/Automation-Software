using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lrt_Ilukste
{
    public partial class FormEditTank : Form
    {
        private OperationData opd = new OperationData();
        int TankID = 0;
        int ActN = 0;
        string StateName = "";
        private TankDataLimits tdl = new TankDataLimits();
        private string Range= "";

        public FormEditTank()
        {
            InitializeComponent();
        }

        public FormEditTank(OperationData op, int tankID, int actN, string stateName)
        {
            opd.AirTemp = op.AirTemp;
            opd.CalcDensity20 = op.CalcDensity20;
            opd.CalcMassa = op.CalcMassa;
            opd.CalcVolume = op.CalcVolume;
            opd.CalcVolume20 = op.CalcVolume20;
            opd.TankAvgTemp = op.TankAvgTemp;
            opd.TankDensity = op.TankDensity;
            opd.TankLevel = op.TankLevel;
            opd.TankTgrad = op.TankTgrad;
            opd.LabDensity20 = op.LabDensity20;
            opd.LabMassa = op.LabMassa;
            opd.MeasureType = op.MeasureType;

            TankID = tankID;
            ActN = actN;
            StateName = stateName;

            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEditTank_Load(object sender, EventArgs e)
        {
            labelelError.Tag = 0;

            textBoxLevel.Text = opd.TankLevel.ToString();
            textBoxAvgTemp.Text = opd.TankAvgTemp.ToString();
            textBoxDensity.Text = opd.TankDensity.ToString();
            textBoxLabDensity20.Text = opd.LabDensity20.ToString();
            if(opd.MeasureType == 0)
            {
                radioButtonMeasureRadar.Checked = true;
                radioButtonMeasureTape.Checked = false;
            }
            if (opd.MeasureType == 1)
            {
                radioButtonMeasureRadar.Checked = false;
                radioButtonMeasureTape.Checked = true;
            }

            // Read Data Limits from Properties.Settings
            tdl.Level_Min = Properties.Settings.Default.Level_Min;
            tdl.Level_Max = Properties.Settings.Default.Level_Max;
            tdl.AvgTemp_Min = Properties.Settings.Default.AvgTemp_Min;
            tdl.AvgTemp_Max = Properties.Settings.Default.AvgTemp_Max;
            tdl.Density_Min = Properties.Settings.Default.Density_Min;
            tdl.Density_Max = Properties.Settings.Default.Density_Max;
            tdl.LabDensity20_Min = Properties.Settings.Default.LabDensity20_Min;
            tdl.LabDensity20_Max = Properties.Settings.Default.LabDensity20_Max;
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            CalculateTankOperation cto = new CalculateTankOperation
            {
                TankID = TankID,
                TankLevel = System.Convert.ToDouble(textBoxLevel.Text.ToString()),
                TankAvgTemp = System.Convert.ToDouble(textBoxAvgTemp.Text.ToString()),
                TankDensity = System.Convert.ToDouble(textBoxDensity.Text.ToString()),
                LabDensity20 = System.Convert.ToDouble(textBoxLabDensity20.Text.ToString())  // Don't calc lab density - only input by Operator
            };

            if (radioButtonMeasureRadar.Checked == true)
                cto.MeasureType = false;
            if (radioButtonMeasureTape.Checked == true) 
                cto.MeasureType = true;

            cto.CalculateCTL20();

            cto.CalculateLabVolume();

            cto.CalculateLabMassa();

            textBoxCalcVolume.Text = String.Format("{0:F3}", cto.CalcVolume); ;
            textBoxCTL20.Text = String.Format("{0:F7}", cto.CTL20);
            textBoxLabVolume20.Text = String.Format("{0:F3}", cto.LabVolume); ;
            textBoxLabMassa.Text = String.Format("{0:F3}", cto.LabMassa); ;

            ButtonSave.Enabled = true;
        }
         
        private void ButtonSave_Click(object sender, EventArgs e)
        {
            FormEdit frm = new FormEdit();
            frm = (FormEdit)this.Owner;

            DateTime dt = DateTime.Now;

            opd.TankLevel = System.Convert.ToSingle(textBoxLevel.Text);
            //"Акт " & strActN & " - РВС " & strTankName & ": Измение взлива с " & prevLevel & " мм на " & txtLevel & " мм"
            SaveEventToDB(dt, "Акт " + ActN.ToString() + " - РВС N" + TankID.ToString() + ", " + StateName + ": Введено новое значение взлива - " + textBoxLevel.Text + " мм");
            opd.TankAvgTemp = System.Convert.ToSingle(textBoxAvgTemp.Text);
            SaveEventToDB(dt, "Акт " + ActN.ToString() + " - РВС N" + TankID.ToString() + ", " + StateName + ": Введено новое значение средней температуры - " + textBoxAvgTemp.Text + " °C");
            opd.TankDensity = System.Convert.ToSingle(textBoxDensity.Text);
            SaveEventToDB(dt, "Акт " + ActN.ToString() + " - РВС N" + TankID.ToString() + ", " + StateName + ": Введено новое значение плотности pi - " + textBoxDensity.Text + " кг/м3");
            opd.CalcVolume = System.Convert.ToSingle(textBoxCalcVolume.Text);
            opd.LabDensity20 = System.Convert.ToSingle(textBoxLabDensity20.Text);
            SaveEventToDB(dt, "Акт " + ActN.ToString() + " - РВС N" + TankID.ToString() + ", " + StateName + ": Введено новое значение лабораторной плотности p20 - " + textBoxLabDensity20.Text + " кг/м3");

            opd.LabVolume20 = System.Convert.ToSingle(textBoxLabVolume20.Text);
            opd.LabMassa = System.Convert.ToSingle(textBoxLabMassa.Text);
            if (radioButtonMeasureRadar.Checked == true)
            {
                opd.MeasureType = 0;
                SaveEventToDB(dt, "Акт " + ActN.ToString() + " - РВС N" + TankID.ToString() + ", " + StateName + ": Измерение взлива произведено радаром");
            }
            if (radioButtonMeasureTape.Checked == true)
            {
                opd.MeasureType = 1;
                SaveEventToDB(dt, "Акт " + ActN.ToString() + " - РВС N" + TankID.ToString() + ", " + StateName + ": Измерение взлива произведено рулеткой");
            }

            frm.AddOperatrionRegisterFromCalculation(opd);

            this.Close();
        }

        private void SaveEventToDB(DateTime dt, string message)
        {
            using (IluksteEntities db = new IluksteEntities())
            {
                // Insert Data to Events
                Events ev = new Events
                {
                    UserID = 2,
                    DataTime = dt,
                    Message = message
                };

                db.Events.Add(ev);
                db.SaveChanges();
            }

        }

        private void textBoxLevel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 127) // цифры, клавиша BackSpace и Del
            {
                e.Handled = true;
            }
        }
        private void textBoxLevel_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int Val;
            bool res = int.TryParse(tb.Text, out Val);
            if (res)
            {
                if (Val < tdl.Level_Min || Val > tdl.Level_Max)
                {
                    e.Cancel = true;
                    tb.SelectAll();
                }
            }
            else
            {
                if (Val > 0)
                {
                    e.Cancel = true;
                    tb.SelectAll();
                }
            }

            if (e.Cancel)
                Range = tdl.Level_Min.ToString() + " - " + tdl.Level_Max.ToString();
            else
                Range = "";
        }

        private void textBoxAvgTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;


            if (e.KeyChar == '-' && (textBox.SelectionStart != 0 || textBox.Text.Contains("-")))
            {
                e.Handled = true;
            }

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 127 && (number != 45 && textBox.SelectionStart != 0)) // цифры, клавиша BackSpace и Del
            {
                e.Handled = true;
            }
        }
        private void textBoxAvgTemp_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            float Val;
            bool res = float.TryParse(tb.Text, out Val);
            if (res)
            {
                if (Val < tdl.AvgTemp_Min || Val > tdl.AvgTemp_Max)
                {
                    e.Cancel = true;
                    tb.SelectAll();
                }
            }
            else
            {
                if (Val > 0)
                {
                    e.Cancel = true;
                    tb.SelectAll();
                }
            }

            if (e.Cancel)
                Range = tdl.AvgTemp_Min.ToString() + " - " + tdl.AvgTemp_Max.ToString();
            else
                Range = "";
        }
        private void textBoxDensity_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 127) // цифры, клавиша BackSpace и Del
            {
                e.Handled = true;
            }
        }
        private void textBoxDensity_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            float Val;
            bool res = float.TryParse(tb.Text, out Val);
            if (res)
            {
                if (Val < tdl.Density_Min || Val > tdl.Density_Max)
                {
                    e.Cancel = true;
                    tb.SelectAll();
                }
            }
            else
            {
                if (Val > 0)
                {
                    e.Cancel = true;
                    tb.SelectAll();
                }
            }

            if (e.Cancel)
                Range = tdl.Density_Min.ToString() + " - " + tdl.Density_Max.ToString();
            else
                Range = "";
        }
        private void textBoxLabDensity20_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46 && number != 127) // цифры, клавиша BackSpace и Del
            {
                e.Handled = true;
            }
        }
        private void textBoxLabDensity20_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            float Val;
            bool res = float.TryParse(tb.Text, out Val);
            if (res)
            {
                if (Val < tdl.LabDensity20_Min || Val > tdl.LabDensity20_Max)
                {
                    e.Cancel = true;
                    tb.SelectAll();
                }
            }
            else
            {
                if (Val > 0)
                {
                    e.Cancel = true;
                    tb.SelectAll();
                }
            }
            if (e.Cancel)
                Range = tdl.LabDensity20_Min.ToString() + " - " + tdl.LabDensity20_Max.ToString();
            else
                Range = "";
        }

        private void textBoxLevel_Enter(object sender, EventArgs e)
        {
            //TextBox TB = (TextBox)sender;
            //int VisibleTime = 1000;  //in milliseconds

            //ToolTip tt = new ToolTip();
            //tt.Show("Test ToolTip", TB, 0, 0, VisibleTime);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (Range != "")
            {
                labelelError.Text = "Ошибка ввода - диапазон: " + Range;
                labelelError.Visible = true;
                labelelError.Tag = (int)labelelError.Tag + 1;
            }

            if ((int)labelelError.Tag > 3)
            {
                labelelError.Visible = false;
                labelelError.Tag = 0;
                Range = "";
            }

            // Check input data which was entered
            if (textBoxLevel.TextLength > 0 && textBoxAvgTemp.TextLength > 0 && textBoxDensity.TextLength > 0 && textBoxLabDensity20.TextLength > 0)
            {
                ButtonCalc.Enabled = true;
            }
            else
            {
                ButtonCalc.Enabled = false;
                ButtonSave.Enabled = false;
            }
        }
    }
}
