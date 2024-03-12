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
    public partial class FormAddTank : Form
    {

        private BindingList<SaabData> dgwList = new BindingList<SaabData>();

        private OperationRegister operReg = new OperationRegister();
        private OperationData operDataStart = new OperationData();
        private OperationData operDataEnd = new OperationData();

        private int RegisterID;

        private bool StartIs = false;
        private bool EndIs = false;
        private string TankName = "";

        public FormAddTank()
        {
            InitializeComponent();
        }



        public FormAddTank(string tankN, bool StartOperIs, bool EndOperIs)
        {
            StartIs = StartOperIs;
            EndIs = EndOperIs;
            TankName = tankN;

            InitializeComponent();
        }

        public FormAddTank(int regid) // <-- New constructor
        {
            InitializeComponent();
            RegisterID = regid;
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddTank_Load(object sender, EventArgs e)
        {
            //  Prepare Edit Form for Register of Operations
            using (IluksteEntities db = new IluksteEntities())
            {
                // Get Users from DB
                //var users = db.Users.ToList();
                //var users = db.Users.Where(p=>p.AccessLevel==200).ToList();
                //DateTime start = DateTime.Now.AddDays(-7);

                // Fill DateTime 
                dateTimePickerDate.Value = DateTime.Now;
                dateTimePickerTime.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, 0);

                // Fill Combno Box Operation State
                if (StartIs == false && EndIs == false)
                {
                    var operstate = db.OperationState.ToList();
                    for (int i = 0; i < operstate.Count; i++)
                    {
                        comboBoxOperState.Items.Add(operstate[i].StateName);
                        comboBoxOperState.SelectedIndex = 0;
                    }

                    // Fill Combo Box Provider
                    var tank = db.Tanks.ToList();
                    for (int i = 0; i < tank.Count; i++)
                    {
                        comboBoxTank.Items.Add(tank[i].TankName);
                        comboBoxTank.SelectedIndex = 0;
                    }
                }
                else
                {
                    comboBoxTank.Items.Add(TankName);
                    comboBoxTank.SelectedIndex = 0;
                    comboBoxTank.Enabled = false;

                    if (StartIs)
                    {
                        comboBoxOperState.Items.Add("Конец операции");
                        comboBoxOperState.Enabled = false;
                    }
                    if (EndIs)
                    {
                        comboBoxOperState.Items.Add("Начало операции");
                        comboBoxOperState.Enabled = false;
                    }
                    comboBoxOperState.SelectedIndex = 0;

                }
            }

            dataGridView1.DataSource = dgwList;
            // Format DataGridView

            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Дата/Время";
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "dd.MM.yyyy HH:mm:ss";
            dataGridView1.Columns[3].HeaderText = "Взлив";
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].Width = 70;
            dataGridView1.Columns[3].DefaultCellStyle.Format = "#####";
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].HeaderText = "tср,°C";
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[4].DefaultCellStyle.Format = "F1";
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].HeaderText = "pi,кг/м³";
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Format = "F2";
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[6].HeaderText = "Vi,м³";
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[6].DefaultCellStyle.Format = "F3";
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].HeaderText = "Мi,т";
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[7].DefaultCellStyle.Format = "F3";
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

        }

        private void ButtonNew_Click(object sender, EventArgs e)
        {
            using (IluksteEntities db = new IluksteEntities())
            {
                // Get OperID from Combno Box Operation State by Name
                var op = db.OperationState.Where(p => p.StateName == comboBoxOperState.SelectedItem.ToString());
                foreach (OperationState o in op)
                {
                    if (o.StateName.CompareTo("Начало операции") == 0)
                    {
                        operDataStart.StateID = o.StateID;
                        // Get OperID from Combno Box Operation State by Name
                        var tank = db.Tanks.Where(p => p.TankName == comboBoxTank.SelectedItem.ToString());
                        foreach (Tanks t in tank)
                        {
                            operReg.TankID = t.TankID;
                            operDataStart.TankTgrad = t.TankTgrad;
                        }

                    }
                    else
                    {
                        operDataEnd.StateID = o.StateID;
                        // Get OperID from Combno Box Operation State by Name
                        var tank = db.Tanks.Where(p => p.TankName == comboBoxTank.SelectedItem.ToString());
                        foreach (Tanks t in tank)
                        {
                            operReg.TankID = t.TankID;
                            operDataEnd.TankTgrad = t.TankTgrad;
                        }
                    }
                }
            }
            FormEdit frm = new FormEdit();
            frm = (FormEdit)this.Owner;
            frm.AddOperationRegisterFromAddTanks(operReg, operDataStart, operDataEnd, comboBoxOperState.SelectedItem.ToString());
            this.Close();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            // Select Real Time Data from Saab Radar - from saved in DB
            using (IluksteEntities db = new IluksteEntities())
            {
                int TankID = 0;
                DateTime dt = Convert.ToDateTime(dateTimePickerDate.Value.ToString("dd.MM.yyyy") + " " + dateTimePickerTime.Value.ToString("HH:mm:ss"));

                // Get OperID from Combno Box Operation State by Name
                var tank = db.Tanks.Where(p => p.TankName == comboBoxTank.SelectedItem.ToString());
                foreach (Tanks t in tank)
                {
                    TankID = t.TankID;
                }
                // Get OperID from Combno Box Operation State by Name
                var op = db.SaabData.Where(p => p.TankID == TankID && p.SaabDateTime < dt).OrderByDescending(p => p.SaabDateTime).FirstOrDefault(); ;
                SaabData sb = (SaabData)op;
                dgwList.Clear();

                DateTime dat = new DateTime(dateTimePickerDate.Value.Year, dateTimePickerDate.Value.Month, dateTimePickerDate.Value.Day, dateTimePickerTime.Value.Hour, dateTimePickerTime.Value.Minute, 0);
    
                sb.SaabDateTime = dat;

                dgwList.Add(sb);

            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            using (IluksteEntities db = new IluksteEntities())
            {
                // Get OperID from Combno Box Operation State by Name
                var op = db.OperationState.Where(p => p.StateName == comboBoxOperState.SelectedItem.ToString());
                foreach (OperationState o in op)
                {
                    if (o.StateName.CompareTo("Начало операции") == 0)
                    {
                        operDataStart.StateID = o.StateID;
                        // Get OperID from Combno Box Operation State by Name
                        var tank = db.Tanks.Where(p => p.TankName == comboBoxTank.SelectedItem.ToString());
                        foreach (Tanks t in tank)
                        {
                            operReg.TankID = t.TankID;
                            operDataStart.TankTgrad = t.TankTgrad;
                        }

                        if(dgwList.Count > 0)
                        {
                            operDataStart.TankLevel = dgwList[0].TankLevel;
                            operDataStart.TankAvgTemp = dgwList[0].TankAvgTemp;
                            operDataStart.TankDensity = dgwList[0].TankDensity;
                        }
                    }
                    else
                    {
                        operDataEnd.StateID = o.StateID;
                        // Get OperID from Combno Box Operation State by Name
                        var tank = db.Tanks.Where(p => p.TankName == comboBoxTank.SelectedItem.ToString());
                        foreach (Tanks t in tank)
                        {
                            operReg.TankID = t.TankID;
                            operDataEnd.TankTgrad = t.TankTgrad;
                        }
                        if (dgwList.Count > 0)
                        {
                            operDataEnd.TankLevel = dgwList[0].TankLevel;
                            operDataEnd.TankAvgTemp = dgwList[0].TankAvgTemp;
                            operDataEnd.TankDensity = dgwList[0].TankDensity;
                        }
                    }
                }
            }

            FormEdit frm = new FormEdit();
            frm = (FormEdit)this.Owner;
            frm.AddOperationRegisterFromAddTanks(operReg, operDataStart, operDataEnd, comboBoxOperState.SelectedItem.ToString());
            this.Close();
        }
    }
}
