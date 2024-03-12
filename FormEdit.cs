using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lrt_Ilukste
{
    public partial class FormEdit : Form
    {

        private int RegisterID = 0;
        private int ActNumber = 0;

        private OperationRegister operReg = new OperationRegister();
        private OperationData operDataStart = new OperationData();
        private OperationData operDataEnd = new OperationData();
        private string OperationName = "";
        private List<OperationState> opsList;

        //declare your list
        private BindingList<TankToDataGrid> dgwList = new BindingList<TankToDataGrid>();

        private bool StartIs = false;
        private bool EndIs = false;

        //private DataTable dt = new DataTable();

        public FormEdit()
        {
            InitializeComponent();
        }

        public void AddOperationRegisterFromAddTanks(OperationRegister operR, OperationData operStart, OperationData operEnd, string operName)
        {
            operReg.TankID = operR.TankID;

            if (operName.CompareTo("Начало операции") == 0)
            {
                operDataStart.StateID = operStart.StateID;
                operDataStart.DataTime = operStart.DataTime;
                operDataStart.TankLevel = operStart.TankLevel;
                operDataStart.TankAvgTemp = operStart.TankAvgTemp;
                operDataStart.TankDensity = operStart.TankDensity;
                operDataStart.CalcVolume = operStart.CalcVolume;
                operDataStart.LabMassa = operStart.LabMassa;
                operDataStart.TankTgrad = operStart.TankTgrad;
            }
            else
            {
                operDataEnd.StateID = operEnd.StateID;
                operDataEnd.DataTime = operEnd.DataTime;
                operDataEnd.TankLevel = operEnd.TankLevel;
                operDataEnd.TankAvgTemp = operEnd.TankAvgTemp;
                operDataEnd.TankDensity = operEnd.TankDensity;
                operDataEnd.CalcVolume = operEnd.CalcVolume;
                operDataEnd.LabMassa = operEnd.LabMassa;
                operDataEnd.TankTgrad = operEnd.TankTgrad;
            }
            OperationName = operName;

        }

        public void AddOperatrionRegisterFromCalculation(OperationData opd)
        {
            if (StartIs == true)
            {
                operDataStart.TankLevel = opd.TankLevel;
                operDataStart.TankAvgTemp = opd.TankAvgTemp;
                operDataStart.TankDensity = opd.TankDensity;
                operDataStart.LabDensity20 = opd.LabDensity20;
                operDataStart.CalcVolume = opd.CalcVolume;
                operDataStart.LabVolume20= opd.LabVolume20;
                operDataStart.LabMassa = opd.LabMassa;
                operDataStart.MeasureType = opd.MeasureType;
            }
            else
            {
                operDataEnd.TankLevel = opd.TankLevel;
                operDataEnd.TankAvgTemp = opd.TankAvgTemp;
                operDataEnd.TankDensity = opd.TankDensity;
                operDataEnd.LabDensity20 = opd.LabDensity20;
                operDataEnd.CalcVolume = opd.CalcVolume;
                operDataEnd.LabVolume20 = opd.LabVolume20;
                operDataEnd.LabMassa = opd.LabMassa;
                operDataEnd.MeasureType = opd.MeasureType;
            }
        }

        public FormEdit(int regid, int actn) // <-- New constructor
        {
            InitializeComponent();
            RegisterID = regid;
            ActNumber = actn;
        }
        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dgwList;
            // Format DataGridView
            dataGridView1.Columns[0].HeaderText = "РВС";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "Статус";
            dataGridView1.Columns[1].Width = 150;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[2].HeaderText = "Взлив";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[3].HeaderText = "tср,°C";
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[4].HeaderText = "pi,кг/м³";
            dataGridView1.Columns[4].Width = 80;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[5].HeaderText = "Vi,м³";
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].HeaderText = "p20,кг/м³";
            dataGridView1.Columns[6].Width = 80;
            dataGridView1.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[7].HeaderText = "V20,м³";
            dataGridView1.Columns[7].Width = 80;
            dataGridView1.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[8].HeaderText = "М,т";
            dataGridView1.Columns[8].Width = 80;
            dataGridView1.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[9].Visible = false;

            if (RegisterID == 0)
            {
                //  Prepare Edit Form for Register of Operations
                using (IluksteEntities db = new IluksteEntities())
                {
                    
                    // Get Users from DB
                    //var users = db.Users.ToList();
                    //var users = db.Users.Where(p=>p.AccessLevel==200).ToList();
                    //DateTime start = DateTime.Now.AddDays(-7);

                    // Fill DateTime 
                    dateTimePickerStart.Value = DateTime.Now;
                    dateTimePickerEnd.Value = DateTime.Now;

                    // Fill Combno Box Operation State
                    var operstate = db.OperationState.ToList();
                    opsList = operstate;

                    // Fill Combno Box Operation Name
                    var opername = db.OperationName.ToList();
                    for (int i = 0; i < opername.Count; i++)
                    {
                        comboBoxOperName.Items.Add(opername[i].OperName);
                    }
                    comboBoxOperName.SelectedIndex = 0;

                    // Fill Combo Box Provider
                    var prov = db.Persons.Where(p => p.PartID == -1 && p.PersActivity == true).ToList();
                    for (int i = 0; i < prov.Count; i++)
                    {
                        comboBoxProv.Items.Add(prov[i].PersName + " " + prov[i].PersSurn);
                    }
                    comboBoxProv.SelectedIndex = 0;

                    // Fill Combo Box Customer
                    var cust = db.Persons.Where(p => p.PartID == 1 && p.PersActivity == true).ToList();
                    for (int i = 0; i < cust.Count; i++)
                    {
                        comboBoxCust.Items.Add(cust[i].PersName + " " + cust[i].PersSurn);
                    }
                    comboBoxCust.SelectedIndex = 0;

                    // Fill New Operation Number
                    var regID = db.OperationRegister.Max(p => p.ActN);
                    if (regID == null)
                        textBoxActN.Text = "1";
                    else
                        textBoxActN.Text = (regID + 1).ToString();

                    // Fill New Operation Number
                    var rID = db.OperationRegister.Max(p => p.ActN);
                    if (rID == null)
                        rID = 0;

                    textBoxActN.Text = (rID + 1).ToString();
                }
            }
            else
            {
                //  Prepare Edit Form for Register of Operations
                using (IluksteEntities db = new IluksteEntities())
                {

                    // Fill Combno Box Operation State
                    var operstate = db.OperationState.ToList();
                    opsList = operstate;

                    // Get Data from OperationREgister
                    var regs = db.OperationRegister.Where(p => p.RegID == RegisterID).FirstOrDefault();
                    if (regs != null)
                    {
                        operReg = (OperationRegister)regs;
                    }

                    // Get Data from OperationData
                    // Fill DateTime 
                    dateTimePickerStart.Value = (DateTime)operReg.StartDataTime;
                    dateTimePickerEnd.Value = (DateTime)operReg.EndDataTime;

                    string name = "";
                    string FirstName = "";
                    string SurnName = "";
                    int ind = 0;

                    // Fill Combno Box Operation Name: (int)operReg.OperID
                    var oper = db.OperationName.Where(p => p.OperID == (int)operReg.OperID).FirstOrDefault();
                    if (oper != null)
                    {
                        name = oper.OperName;
                        ind = 0;
                        var opername = db.OperationName.ToList();
                        for (int i = 0; i < opername.Count; i++)
                        {
                            if (opername[i].OperName == name)
                                ind = i;
                            comboBoxOperName.Items.Add(opername[i].OperName);
                        }
                        comboBoxOperName.SelectedIndex = ind;
                    }

                    // Fill Combo Box Provider: (int)operReg.ProvID
                    var sel2 = db.Persons.Where(p => p.PersID == (int)operReg.ProvID).ToList();
                    var prov = db.Persons.Where(p => p.PartID == -1).ToList();
                    if (sel2.Count > 0)
                    {
                        SurnName = sel2[0].PersSurn;
                        FirstName = sel2[0].PersName;
                        ind = 0;
                        for (int i = 0; i < prov.Count; i++)
                        {
                            if (prov[i].PersSurn == SurnName && prov[i].PersName == FirstName)
                                ind = i;
                            comboBoxProv.Items.Add(prov[i].PersName + " " + prov[i].PersSurn);
                        }
                        comboBoxProv.SelectedIndex = ind;
                    }


                    // Fill Combo Box Customer: (int)operReg.CustID
                    var sel3 = db.Persons.Where(p => p.PersID == (int)operReg.CustID).ToList();
                    var cust = db.Persons.Where(p => p.PartID == 1).ToList();
                    if (sel3.Count > 0)
                    {
                        SurnName = sel3[0].PersSurn;
                        FirstName = sel3[0].PersName;
                        ind = 0;
                        for (int i = 0; i < cust.Count; i++)
                        {
                            if (cust[i].PersSurn == SurnName && cust[i].PersName == FirstName)
                                ind = i;
                            comboBoxCust.Items.Add(cust[i].PersName + " " + cust[i].PersSurn);
                        }
                        comboBoxCust.SelectedIndex = ind;
                    }

                    // Fill New Operation Number
                    
                    textBoxActN.Text = ActNumber.ToString();
        
                    // Fill Operation Data
                    var dat = db.OperationData.Where(p => p.RegID == RegisterID).ToList();
                    if (dat.Count > 0)
                    {
                        for (int i = 0; i < dat.Count; i++)
                        {
                            short stID = (short)dat[i].StateID;
                            var st = db.OperationState.Where(p => p.StateID == stID).ToList();
                            if (st.Count > 0)
                            {
                                if (st[0].StateName == "Начало операции")
                                {
                                    operDataStart = (OperationData)dat[i];
                                }
                                else
                                {
                                    operDataEnd = (OperationData)dat[i];
                                }
                            }
                        }
                        List<TankToDataGrid> opdList = GetOperationDataToGrid(RegisterID);
                        for (int y = 0; y < opdList.Count; y++)
                        {
                            dgwList.Add(opdList[y]);
                        }
                        dataGridView1.Refresh();
                    }

                }
            }
        }

        private void ButtonAppend_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                int i = dataGridView1.CurrentCell.RowIndex;

                //if (dataGridView1.Rows[i].Cells[1].Value.ToString().CompareTo("Начало операции") == 0)
                if (dgwList[i].StateName.CompareTo("Начало операции") == 0)
                {
                    StartIs = true;
                    EndIs = false;
                }
                else
                {
                    StartIs = false;
                    EndIs = true;
                }

                string TankN = dgwList[i].TankName;
                //using (IluksteEntities db = new IluksteEntities())
                //{
                //    // Get TankID from DB by TankName
                //    var tank = db.Tanks.Where(p => p.TankName == TankN).ToList();
                //    if(tank.Count > 0)
                //    {
                //        TankID = tank[0].TankID;
                //    }
                //}
                Form frm1 = new FormAddTank(TankN, StartIs, EndIs);
                DialogResult result1 = frm1.ShowDialog(this);

                if (result1 == DialogResult.OK)
                {
                    // Add data to dataGridView1
                    TankToDataGrid tdg = new TankToDataGrid();
                    tdg.TankName = TankN;
                    tdg.StateName = OperationName;
                    dgwList.Add(tdg);
                }
            }
            else
            {
                Form frm = new FormAddTank();
                DialogResult result = frm.ShowDialog(this);

                if (result == DialogResult.OK)
                {

                    using (IluksteEntities db = new IluksteEntities())
                    {
                        string TankName = "";

                        // Get TankName from DB by ID
                        var tank = db.Tanks.Where(p => p.TankID == operReg.TankID);
                        foreach (Tanks t in tank)
                        {
                            TankName = t.TankName;
                            operReg.TankID = t.TankID;
                        }

                        // Add data to dataGridView1
                        TankToDataGrid tdg = new TankToDataGrid();
                        tdg.TankName = TankName;
                        tdg.StateName = OperationName;
                        if (tdg.StateName.CompareTo("Начало операции") == 0)
                        {
                            tdg.TankLevel = operDataStart.TankLevel.ToString();
                            tdg.TankAvgTemp = operDataStart.TankAvgTemp.ToString();
                            tdg.TankDensity = operDataStart.TankDensity.ToString();
                        }
                        else
                        {
                            tdg.TankLevel = operDataEnd.TankLevel.ToString();
                            tdg.TankAvgTemp = operDataEnd.TankAvgTemp.ToString();
                            tdg.TankDensity = operDataEnd.TankDensity.ToString();
                        }

                        dgwList.Add(tdg);
                        //dataGridView1.Rows.Add(TankName, OperationName);

                    }
                }
            }

        }

        private List<TankToDataGrid> GetOperationDataToGrid(int RegID)
        {
            List<TankToDataGrid> addl = new List<TankToDataGrid>();

            SqlParameter Param1 = new SqlParameter("@Param1", RegID);

            using (IluksteEntities db = new IluksteEntities())
            {
                // 
                var op = db.Database.SqlQuery<AddTankToOperation>(@"SELECT dbo.Tanks.TankName, dbo.OperationState.StateName, dbo.OperationData.TankLevel, dbo.OperationData.TankAvgTemp, dbo.OperationData.TankDensity, dbo.OperationData.CalcVolume, 
                         dbo.OperationData.LabDensity20, dbo.OperationData.LabVolume20, dbo.OperationData.LabMassa, dbo.OperationRegister.RegID, dbo.OperationData.MeasureType
                            FROM dbo.OperationRegister INNER JOIN
                                dbo.OperationData ON dbo.OperationRegister.RegID = dbo.OperationData.RegID INNER JOIN
                                dbo.OperationState ON dbo.OperationData.StateID = dbo.OperationState.StateID INNER JOIN
                                dbo.Tanks ON dbo.OperationRegister.TankID = dbo.Tanks.TankID
                            WHERE (dbo.OperationRegister.RegID = @Param1)
                            ORDER BY dbo.OperationRegister.RegID, dbo.OperationData.StateID", Param1).ToList(); ;
                if (op.Count > 0)
                {
                    for (int i = 0; i < op.Count; i++ )
                    {
                        TankToDataGrid tank = new TankToDataGrid();

                        tank.TankName = op[i].TankName;
                        tank.StateName = op[i].StateName;
                        tank.TankLevel = op[i].TankLevel.ToString();
                        tank.TankAvgTemp = op[i].TankAvgTemp.ToString();
                        tank.TankDensity = op[i].TankDensity.ToString();
                        tank.CalcVolume = op[i].CalcVolume.ToString();
                        tank.LabDensity20 = op[i].LabDensity20.ToString();
                        tank.LabVolume20 = op[i].LabVolume20.ToString();
                        tank.LabMassa = op[i].LabMassa.ToString();
                        tank.MeasureType = op[i].MeasureType.ToString();

                        addl.Add(tank);
                    }
                }
            }
                return addl;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (FormMain.ProgramAccessLevel < 500)
            {
                ButtonAppend.Enabled = false;
                ButtonEdit.Enabled = false;
                ButtonDelete.Enabled = false;
                //ButtonPrint.Enabled = false;
                textBoxMassa.Text = TotalMassaCalculation().ToString();
            }
            else
            {
                if (dataGridView1.Rows.Count == 2)
                {
                    ButtonAppend.Enabled = false;
                }
                else
                {
                    ButtonAppend.Enabled = true;
                }

                if (dataGridView1.Rows.Count > 0)
                {

                    ButtonEdit.Enabled = true;
                    ButtonDelete.Enabled = true;

                    textBoxMassa.Text = TotalMassaCalculation().ToString();
                }
                else
                {
                    ButtonEdit.Enabled = false;
                    ButtonDelete.Enabled = false;
                }
            }
        }

        private float TotalMassaCalculation()
        {
            float summa = 0;
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                var stID = opsList.Where(p => p.StateName == r.Cells[1].Value.ToString()).ToList();
                if (stID != null)
                {
                    if (r.Cells[5].Value != null)
                    {
                        if (r.Cells[5].Value.ToString().Length > 0)
                            summa += System.Convert.ToSingle(r.Cells[8].Value.ToString()) * stID[0].StateID;
                    }
                }
            }
            summa = Math.Abs(summa);

            return summa;
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;

            OperationData opd = new OperationData();

            //dataGridView1.Columns[0].HeaderText = "РВС";
            //dataGridView1.Columns[0].Width = 50;
            //dataGridView1.Columns[1].HeaderText = "Статус";
            //dataGridView1.Columns[1].Width = 150;
            //dataGridView1.Columns[2].HeaderText = "Взлив";
            //dataGridView1.Columns[2].Width = 70;
            //dataGridView1.Columns[3].HeaderText = "tср,°C";
            //dataGridView1.Columns[3].Width = 80;
            //dataGridView1.Columns[4].HeaderText = "pi,кг/м³";
            //dataGridView1.Columns[4].Width = 80;
            //dataGridView1.Columns[5].HeaderText = "Vi,м³";
            //dataGridView1.Columns[5].Width = 80;
            //dataGridView1.Columns[6].HeaderText = "p20,кг/м³";
            //dataGridView1.Columns[6].Width = 80;
            //dataGridView1.Columns[7].HeaderText = "V20,м³";
            //dataGridView1.Columns[7].Width = 80;
            //dataGridView1.Columns[8].HeaderText = "М,т";
            //dataGridView1.Columns[8].Width = 80;
            if (dataGridView1.Rows[i].Cells[2].Value != null)
            {
                if (String.IsNullOrEmpty(dataGridView1.Rows[i].Cells[2].Value.ToString()) == false)
                    opd.TankLevel = Convert.ToSingle(dataGridView1.Rows[i].Cells[2].Value.ToString());
            }
            if (dataGridView1.Rows[i].Cells[3].Value != null)
            {
                if (String.IsNullOrEmpty(dataGridView1.Rows[i].Cells[3].Value.ToString()) == false)
                    opd.TankAvgTemp = Convert.ToSingle(dataGridView1.Rows[i].Cells[3].Value.ToString());
            }
            if (dataGridView1.Rows[i].Cells[4].Value != null)
            {
                if (String.IsNullOrEmpty(dataGridView1.Rows[i].Cells[4].Value.ToString()) == false)
                    opd.TankDensity = Convert.ToSingle(dataGridView1.Rows[i].Cells[4].Value.ToString());
            }
            // opd.CalcVolume  = Convert.ToSingle(dataGridView1.Rows[i].Cells[5].Value.ToString());
            if (dataGridView1.Rows[i].Cells[6].Value != null)
            {
                if (String.IsNullOrEmpty(dataGridView1.Rows[i].Cells[6].Value.ToString()) == false)
                    opd.LabDensity20 = Convert.ToSingle(dataGridView1.Rows[i].Cells[6].Value.ToString());
            }
            // opd.CalcVolume20 = Convert.ToSingle(dataGridView1.Rows[i].Cells[7].Value.ToString());
            // opd.LabMassa = Convert.ToSingle(dataGridView1.Rows[i].Cells[8].Value.ToString());
            if (dataGridView1.Rows[i].Cells[9].Value != null)
            {
                if (String.IsNullOrEmpty(dataGridView1.Rows[i].Cells[9].Value.ToString()) == false)
                    opd.MeasureType = Convert.ToByte(dataGridView1.Rows[i].Cells[9].Value.ToString());
            }

            //if (dataGridView1.Rows[i].Cells[1].Value.ToString().CompareTo("Начало операции") == 0)
            if (dgwList[i].StateName.CompareTo("Начало операции") == 0)
            {
                StartIs = true;
            }
            else
            {
                StartIs = false;
            }

            //if (dataGridView1.Rows[i].Cells[1].Value.ToString().CompareTo("Kонец операции") == 0)
            //if (dgwList[i].StateName.CompareTo("Kонец операции") == 0)
            //    StartIs = false;

            int tankID = (int)operReg.TankID;
            int ActN = Convert.ToInt32(textBoxActN.Text);
            FormEditTank frm = new FormEditTank(opd, tankID, ActN, dgwList[i].StateName);
            DialogResult result = frm.ShowDialog(this);

            if (result == DialogResult.OK)
            {

                if (StartIs == true)
                    opd = operDataStart;
                else
                    opd = operDataEnd;

                // Fill List and refresh DataGriedView

                dgwList[i].TankLevel = opd.TankLevel.ToString();
                dgwList[i].TankAvgTemp = opd.TankAvgTemp.ToString();
                dgwList[i].TankDensity = opd.TankDensity.ToString();
                dgwList[i].CalcVolume = opd.CalcVolume.ToString();
                dgwList[i].LabDensity20 = opd.LabDensity20.ToString();
                dgwList[i].LabVolume20 = opd.LabVolume20.ToString();
                dgwList[i].LabMassa = opd.LabMassa.ToString();
                dataGridView1.Refresh();
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Желаете удалить запись?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                dgwList.RemoveAt(i);
                dataGridView1.Refresh();
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            operReg.StartDataTime = dateTimePickerStart.Value;
            operReg.EndDataTime = dateTimePickerEnd.Value;
            using (IluksteEntities db = new IluksteEntities())
            {
                // Get Operation OperID from ComboBox
                var op = db.OperationName.Where(p => p.OperName == comboBoxOperName.SelectedItem.ToString());
                foreach (OperationName o in op)
                {
                    operReg.OperID = o.OperID;
                }
                // Get Provider ProvID from ComboBox
                char[] separators = new char[] { ' ' };
                string[] strProv = comboBoxProv.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                string SurnName = strProv[1];
                string FirstName = strProv[0];
                var prov = db.Persons.Where(p => p.PersName == FirstName && p.PersSurn == SurnName).FirstOrDefault();
                if (prov != null)
                    operReg.ProvID = prov.PersID;

                // Get Customer CustID from ComboBox
                string[] strCust = comboBoxCust.Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                SurnName = strCust[1];
                FirstName = strCust[0];
                var cust = db.Persons.Where(p => p.PersName == FirstName && p.PersSurn == SurnName).FirstOrDefault();
                if (cust != null)
                    operReg.CustID = cust.PersID;

                operReg.ActN = System.Convert.ToInt32(textBoxActN.Text);
                operReg.CreateDataTime = DateTime.Now;
                if (dataGridView1.Rows.Count == 2)
                    operReg.FullReport = true;
                else
                    operReg.FullReport = false;
            

                // Save Operation Data to DB
                var regs = db.OperationRegister.Where(p => p.RegID == RegisterID).FirstOrDefault();
                if (regs == null)
                {
                    db.OperationRegister.Add(operReg);
                    db.SaveChanges();
                    RegisterID = operReg.RegID;

                    var dat = db.OperationData.Where(p => p.RegID == RegisterID).FirstOrDefault();
                    if (dat == null)
                    {
                        for (int i = 0; i < dgwList.Count; i ++)
                        {
                            if (dgwList[i].StateName == "Начало операции")
                            {
                                operDataStart.RegID = RegisterID;
                                db.OperationData.Add(operDataStart);
                                db.SaveChanges();
                            }
                            else
                            {
                                operDataEnd.RegID = RegisterID;
                                db.OperationData.Add(operDataEnd);
                                db.SaveChanges();
                            }
                        }
                    }
                }
                else
                {
                    OperationRegister reg = db.OperationRegister.Where(p => p.RegID == RegisterID).FirstOrDefault();
                    reg.StartDataTime = operReg.StartDataTime;
                    reg.EndDataTime = operReg.EndDataTime;
                    reg.CustID = operReg.CustID;
                    reg.OperID = operReg.OperID;
                    reg.ProvID = operReg.ProvID;
                    reg.FullReport = operReg.FullReport;
                    reg.OperID = operReg.OperID;
                    reg.TankID = operReg.TankID;
                    reg.ActN = operReg.ActN;
                    db.SaveChanges();

                    var dat = db.OperationData.Where(p => p.RegID == RegisterID).FirstOrDefault();
                    if (dat == null)
                    {
                        if (dataGridView1.Rows.Count == 2)
                        {
                            operDataStart.RegID = RegisterID;
                            db.OperationData.Add(operDataStart);
                            db.SaveChanges();

                            operDataEnd.RegID = RegisterID;
                            db.OperationData.Add(operDataEnd);
                            db.SaveChanges();
                        }
                        else
                        {
                            if (dgwList[0].StateName == "Начало операции")
                            {
                                operDataStart.RegID = operReg.RegID;
                                db.OperationData.Add(operDataStart);
                                db.SaveChanges();
                            }
                            else
                            {
                                operDataEnd.RegID = operReg.RegID;
                                db.OperationData.Add(operDataEnd);
                                db.SaveChanges();
                            }
                        }
                    }
                    else
                    {
                        short stID = 0;
                        short enID = 0;
                        bool stUpdate = false;
                        bool enUpdate = false;

                        var stoper = db.OperationState.Where(p => p.StateName == "Начало операции").ToList();
                        var enoper = db.OperationState.Where(p => p.StateName == "Конец операции").ToList();
                        if (stoper.Count > 0)
                            stID = stoper[0].StateID;
                        if (enoper.Count > 0)
                            enID = enoper[0].StateID;

                        var dat1 = db.OperationData.Where(p => p.RegID == RegisterID);
                        foreach (OperationData d in dat1)
                        {
                            //db.OperationData.Remove(d);
                            if (d.StateID == stID)
                            {
                                operDataStart.RegID = RegisterID;
                                d.AirTemp = operDataStart.AirTemp;
                                d.CalcDensity20 = operDataStart.CalcDensity20;
                                d.CalcMassa = operDataStart.CalcMassa;
                                d.CalcVolume = operDataStart.CalcVolume;
                                d.CalcVolume20 = operDataStart.CalcVolume20;
                                d.DataTime = operDataStart.DataTime;
                                d.LabDensity = operDataStart.LabDensity;
                                d.LabDensity20 = operDataStart.LabDensity20;
                                d.LabMassa = operDataStart.LabMassa;
                                d.LabVolume = operDataStart.LabVolume;
                                d.LabVolume20 = operDataStart.LabVolume20;
                                d.MeasureType = operDataStart.MeasureType;
                                d.RegID = operDataStart.RegID;
                                d.StateID = operDataStart.StateID;
                                d.TankAvgTemp = operDataStart.TankAvgTemp;
                                d.TankDensity = operDataStart.TankDensity;
                                d.TankLevel = operDataStart.TankLevel;
                                d.TankTgrad = operDataStart.TankTgrad;
                                stUpdate = true;
                            }
                            if (d.StateID == enID)
                            {
                                operDataEnd.RegID = RegisterID;
                                operDataStart.RegID = RegisterID;
                                d.AirTemp = operDataEnd.AirTemp;
                                d.CalcDensity20 = operDataEnd.CalcDensity20;
                                d.CalcMassa = operDataEnd.CalcMassa;
                                d.CalcVolume = operDataEnd.CalcVolume;
                                d.CalcVolume20 = operDataEnd.CalcVolume20;
                                d.DataTime = operDataEnd.DataTime;
                                d.LabDensity = operDataEnd.LabDensity;
                                d.LabDensity20 = operDataEnd.LabDensity20;
                                d.LabMassa = operDataEnd.LabMassa;
                                d.LabVolume = operDataEnd.LabVolume;
                                d.LabVolume20 = operDataEnd.LabVolume20;
                                d.MeasureType = operDataEnd.MeasureType;
                                d.RegID = operDataEnd.RegID;
                                d.StateID = operDataEnd.StateID;
                                d.TankAvgTemp = operDataEnd.TankAvgTemp;
                                d.TankDensity = operDataEnd.TankDensity;
                                d.TankLevel = operDataEnd.TankLevel;
                                d.TankTgrad = operDataEnd.TankTgrad;
                                enUpdate = true;
                            }
                        }
                        db.SaveChanges();

                        if ( dgwList.Count == 2 && ( stUpdate == false || enUpdate == false))
                        {
                            if(stUpdate == false)
                            {
                                OperationData opd1 = new OperationData();
                                operDataStart.RegID = RegisterID;
                                opd1.AirTemp = operDataStart.AirTemp;
                                opd1.CalcDensity20 = operDataStart.CalcDensity20;
                                opd1.CalcMassa = operDataStart.CalcMassa;
                                opd1.CalcVolume = operDataStart.CalcVolume;
                                opd1.CalcVolume20 = operDataStart.CalcVolume20;
                                opd1.DataTime = operDataStart.DataTime;
                                opd1.LabDensity = operDataStart.LabDensity;
                                opd1.LabDensity20 = operDataStart.LabDensity20;
                                opd1.LabMassa = operDataStart.LabMassa;
                                opd1.LabVolume = operDataStart.LabVolume;
                                opd1.LabVolume20 = operDataStart.LabVolume20;
                                opd1.MeasureType = operDataStart.MeasureType;
                                opd1.RegID = operDataStart.RegID;
                                opd1.StateID = operDataStart.StateID;
                                opd1.TankAvgTemp = operDataStart.TankAvgTemp;
                                opd1.TankDensity = operDataStart.TankDensity;
                                opd1.TankLevel = operDataStart.TankLevel;
                                opd1.TankTgrad = operDataStart.TankTgrad;

                                db.OperationData.Add(opd1);
                                db.SaveChanges();
                            }
                            if (enUpdate == false)
                            {
                                OperationData opd2 = new OperationData();
                                operDataEnd.RegID = RegisterID;
                                opd2.AirTemp = operDataEnd.AirTemp;
                                opd2.CalcDensity20 = operDataEnd.CalcDensity20;
                                opd2.CalcMassa = operDataEnd.CalcMassa;
                                opd2.CalcVolume = operDataEnd.CalcVolume;
                                opd2.CalcVolume20 = operDataEnd.CalcVolume20;
                                opd2.DataTime = operDataEnd.DataTime;
                                opd2.LabDensity = operDataEnd.LabDensity;
                                opd2.LabDensity20 = operDataEnd.LabDensity20;
                                opd2.LabMassa = operDataEnd.LabMassa;
                                opd2.LabVolume = operDataEnd.LabVolume;
                                opd2.LabVolume20 = operDataEnd.LabVolume20;
                                opd2.MeasureType = operDataEnd.MeasureType;
                                opd2.RegID = operDataEnd.RegID;
                                opd2.StateID = operDataEnd.StateID;
                                opd2.TankAvgTemp = operDataEnd.TankAvgTemp;
                                opd2.TankDensity = operDataEnd.TankDensity;
                                opd2.TankLevel = operDataEnd.TankLevel;
                                opd2.TankTgrad = operDataEnd.TankTgrad;

                                db.OperationData.Add(opd2);
                                db.SaveChanges();
                            }
                        }


                    


                        //if (dataGridView1.Rows.Count == 2)
                        //{
                        //    db.OperationData.Add(operDataStart);
                        //    //db.SaveChanges();

                        //    db.OperationData.Add(operDataEnd);
                        //    db.SaveChanges();
                        //}
                        //else
                        //{
                        //    if (dgwList[0].StateName == "Начало операции")
                        //    {
                        //        db.OperationData.Add(operDataStart);
                        //        db.SaveChanges();
                        //    }
                        //    else
                        //    {
                        //        db.OperationData.Add(operDataEnd);
                        //        db.SaveChanges();
                        //    }
                        //}
                    }
                }  
            }
        }
    }
}
