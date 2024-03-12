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
using Word = Microsoft.Office.Interop.Word;
using RSDN;
using System.IO;

namespace Lrt_Ilukste
{
    public partial class FormReg : Form
    {

        //private List<OperationRegData> opList;
        //declare your list
        private BindingList<OperationRegData> opList = new BindingList<OperationRegData>();
        //private List<OperationRegData> operList;

        public FormReg()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAppend_Click(object sender, EventArgs e)
        {
            Form NewForm = new FormEdit();
            DialogResult result = NewForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DateTime StartTime = dateTimePickerStart.Value;
                DateTime EndTime = dateTimePickerEnd.Value;
                SelectOpearationDataToGrid(StartTime, EndTime);
            }
        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = opList;

            // Format DataGridView
            dataGridView1.Columns[0].HeaderText = "Отчёт №";
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].HeaderText = "РВС";
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].HeaderText = "Дата начала";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].HeaderText = "Дата конца";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[4].HeaderText = "Название операции";
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].HeaderText = "Масса";
            dataGridView1.Columns[5].Width = 80;
            dataGridView1.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns[6].HeaderText = "Дата создания";
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            //  Check Register of Operations
            using (IluksteEntities db = new IluksteEntities())
            {
                // Get Users from DB
                //var users = db.Users.ToList();
                //var users = db.Users.Where(p=>p.AccessLevel==200).ToList();
                DateTime start = DateTime.Now.AddDays(-7);
                dateTimePickerStart.Value = start;
                dateTimePickerEnd.Value = DateTime.Now.AddDays(1);

                SelectOpearationDataToGrid(start, DateTime.Now);
                //var regs = db.OperationRegister.Where(p => p.StartDataTime > start && p.StartDataTime > DateTime.Now).ToList();

            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            int RegID = (int)opList[i].RegID;
            int ActN = (int)opList[i].ActN;

            FormEdit frm = new FormEdit(RegID, ActN);
            var result = frm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                DateTime StartTime = dateTimePickerStart.Value;
                DateTime EndTime = dateTimePickerEnd.Value;
                SelectOpearationDataToGrid(StartTime, EndTime);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Желаете удалить запись?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int i = dataGridView1.CurrentCell.RowIndex;
                int RegID = (int)opList[i].RegID;
                using (IluksteEntities db = new IluksteEntities())
                {
                    var regs = db.OperationRegister.Where(p => p.RegID == RegID).ToList();
                    if (regs.Count > 0)
                    {
                        OperationRegister or = regs[0];
                        db.OperationRegister.Remove(or);
                        db.SaveChanges();
                    }
                }
                DateTime StartTime = dateTimePickerStart.Value;
                DateTime EndTime = dateTimePickerEnd.Value;
                SelectOpearationDataToGrid(StartTime, EndTime);
                dataGridView1.Focus();
                dataGridView1.Refresh();
            }
        }

        private void ButtonPrint_Click(object sender, EventArgs e)
        {
            // Create Word document
            Word.Document doc = null;
            try
            {
                // Create word Application
                Word.Application app = new Word.Application();
                // Get template document path
                string source = Properties.Settings.Default.DocumentPath;
                // Open Word
                doc = app.Documents.Open(source);
                doc.Activate();
                doc.Application.Visible = true;

                // Get Data From DB
                int y = dataGridView1.CurrentCell.RowIndex;
                int RegID = (int)opList[y].RegID;
                float TotalMassa = (float)opList[y].Massa;
                string TankName = (string)opList[y].TankName;
                string OperName = (string)opList[y].OperName;
                string StartTime = (string)opList[y].StartDataTime.ToString();
                string EndTime = (string)opList[y].EndDataTime.ToString();

                OperationRegister OperReg = new OperationRegister();
                //OperationData operDataStart = new OperationData();
                //OperationData operDataEnd = new OperationData();

                List<TankToDataGrid> opdList = new List<TankToDataGrid>();
                string ProviderName = "";
                string CustomerName = "";

                using (IluksteEntities db = new IluksteEntities())
                {
                    // Fill Operation Data
                    var regs = db.OperationRegister.Where(p => p.RegID == RegID).ToList();
                    if (regs.Count > 0)
                    {
                        OperReg = regs[0];
                        opdList = GetOperationDataToGrid(RegID);

                        // Fill Combo Box Customer: (int)operReg.CustID
                        var cust = db.Persons.Where(p => p.PersID == OperReg.CustID).ToList();
                        if (cust.Count > 0)
                            CustomerName = cust[0].PersSurn + " " + cust[0].PersName;

                        var prov = db.Persons.Where(p => p.PersID == OperReg.ProvID).ToList();
                        if (prov.Count > 0)
                            ProviderName = prov[0].PersSurn + " " + prov[0].PersName;
                    }
                }

                
                // Put Data to Bookmarks
                doc.Bookmarks["ActN"].Range.Text = OperReg.ActN.ToString();
                doc.Bookmarks["OperName"].Range.Text =OperName;
                doc.Bookmarks["StartDataTime"].Range.Text = StartTime;
                doc.Bookmarks["EndDataTime"].Range.Text = EndTime;

                doc.Bookmarks["Tank1"].Range.Text = TankName;
                doc.Bookmarks["StateName1"].Range.Text = opdList[0].StateName;
                doc.Bookmarks["Level1"].Range.Text = opdList[0].TankLevel.ToString();
                float avgT1 = Convert.ToSingle(opdList[0].TankAvgTemp);
                doc.Bookmarks["AvgTemp1"].Range.Text =avgT1.ToString("0.0");
                doc.Bookmarks["Volume1"].Range.Text = opdList[0].LabVolume20.ToString();
                doc.Bookmarks["Density1"].Range.Text = opdList[0].LabDensity20.ToString();
                doc.Bookmarks["Massa1"].Range.Text = opdList[0].LabMassa.ToString();

                doc.Bookmarks["Tank2"].Range.Text = TankName;
                doc.Bookmarks["StateName2"].Range.Text = opdList[1].StateName;
                doc.Bookmarks["Level2"].Range.Text = opdList[1].TankLevel.ToString();
                float avgT2 = Convert.ToSingle(opdList[1].TankAvgTemp);
                doc.Bookmarks["AvgTemp2"].Range.Text = avgT2.ToString("0.0");
                doc.Bookmarks["Volume2"].Range.Text = opdList[1].LabVolume20.ToString();
                doc.Bookmarks["Density2"].Range.Text = opdList[1].LabDensity20.ToString();
                doc.Bookmarks["Massa2"].Range.Text = opdList[1].LabMassa.ToString();

                doc.Bookmarks["TotalMassa"].Range.Text = TotalMassa.ToString();
                doc.Bookmarks["JugoZapad"].Range.Text = ProviderName;
                doc.Bookmarks["latRosTrans"].Range.Text = CustomerName;


                string strm = RusCurrency.Str(TotalMassa, "Тонна");
                doc.Bookmarks["TotalMassaRus"].Range.Text = strm; ;

                // Закрываем документ
                //doc.Close();
                //doc = null;
            }
            catch (Exception ex)
            {
                // Если произошла ошибка, то
                // закрываем документ и выводим информацию
                doc.Close();
                doc = null;

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
                         dbo.OperationData.LabDensity20, dbo.OperationData.LabVolume20, dbo.OperationData.LabMassa, dbo.OperationRegister.RegID
                            FROM dbo.OperationRegister INNER JOIN
                                dbo.OperationData ON dbo.OperationRegister.RegID = dbo.OperationData.RegID INNER JOIN
                                dbo.OperationState ON dbo.OperationData.StateID = dbo.OperationState.StateID INNER JOIN
                                dbo.Tanks ON dbo.OperationRegister.TankID = dbo.Tanks.TankID
                            WHERE (dbo.OperationRegister.RegID = @Param1)
                            ORDER BY dbo.OperationRegister.RegID, dbo.OperationData.StateID", Param1).ToList(); ;
                if (op.Count > 0)
                {
                    for (int i = 0; i < op.Count; i++)
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

                        addl.Add(tank);
                    }
                }
            }
            return addl;

        }


        private void SelectOpearationDataToGrid(DateTime StartTime, DateTime EndTime)
        {
            List<OperationRegData> opl = GetOperationRegisterData(StartTime, EndTime);
            //System.Collections.IList list = (System.Collections.IList)opl;
            if (opl != null)
            {
                opList.Clear();
                for (int i = 0; i < opl.Count; i++)
                {
                    opList.Add(opl[i]);

                }
            }

            dataGridView1.Refresh();
        }

        private List<OperationRegData> GetOperationRegisterData(DateTime StartTime, DateTime EndTime)
        {
            List<OperationRegData> operList = new List<OperationRegData>();

            //  Check Register of Operations
            using (IluksteEntities db = new IluksteEntities())
            {
               

                // Get Users from DB
                SqlParameter param1 = new SqlParameter("@StartTime", StartTime);
                SqlParameter param2 = new SqlParameter("@EndTime", EndTime);

                var regs = db.Database.SqlQuery<OperationRegData>(@"SELECT MAX(dbo.OperationRegister.ActN) AS ActN, dbo.Tanks.TankName,
                            MAX(dbo.OperationRegister.StartDataTime) AS StartDataTime,  
                            MAX(dbo.OperationRegister.EndDataTime) AS EndDataTime, MAX(dbo.OperationName.OperName) AS OperName,
                            ROUND(ABS(SUM(dbo.OperationData.LabMassa * dbo.OperationData.StateID)), 3) AS Massa,
                            MAX(dbo.OperationRegister.CreateDataTime) AS CreateDataTime, dbo.OperationRegister.RegID,  COUNT(dbo.OperationRegister.FullReport) AS FullReport
                            FROM  dbo.OperationData RIGHT OUTER JOIN
                                dbo.OperationName INNER JOIN
                                dbo.OperationRegister ON dbo.OperationName.OperID = dbo.OperationRegister.OperID INNER JOIN
                                dbo.Tanks ON dbo.OperationRegister.TankID = dbo.Tanks.TankID ON dbo.OperationData.RegID = dbo.OperationRegister.RegID
                            GROUP BY dbo.Tanks.TankName, dbo.OperationRegister.RegID
                              HAVING (MAX(dbo.OperationRegister.StartDataTime) >= @StartTime) AND (MAX(dbo.OperationRegister.StartDataTime) <= @EndTime)
                            ORDER BY ActN", new SqlParameter[] { param1, param2 }).ToList();

                foreach (OperationRegData opr in regs)
                {

                    operList.Add(opr);
                }
                //var regs = db.OperationRegister.Where(p => p.StartDataTime > start && p.StartDataTime > DateTime.Now).ToList();



                //opList = (OperationRegData)regs;
            }
                return operList;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            if (FormMain.ProgramAccessLevel >= 500)
            {
                if (opList != null)
                {
                    if (opList.Count == 0)
                    {
                        // Operation Register is empty
                        ButtonAppend.Enabled = true;
                        ButtonEdit.Enabled = false;
                        ButtonDelete.Enabled = false;
                        //ButtonPrint.Enabled = false;
                    }
                    else
                    {
                        ButtonAppend.Enabled = true;
                        ButtonEdit.Enabled = true;
                        ButtonDelete.Enabled = true;
                        //ButtonPrint.Enabled = false;
                    }
                }
                else
                {
                    // Operation Register is empty
                    ButtonAppend.Enabled = true;
                    ButtonEdit.Enabled = false;
                    ButtonDelete.Enabled = false;
                    //ButtonPrint.Enabled = false;
                }
            }
            else
            {
                ButtonAppend.Enabled = false;
                ButtonEdit.Enabled = false;
                ButtonDelete.Enabled = false;
                //ButtonPrint.Enabled = false;
            }

        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            DateTime StartTime = dateTimePickerStart.Value;
            DateTime EndTime = dateTimePickerEnd.Value;
            SelectOpearationDataToGrid(StartTime, EndTime);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonPrint.Enabled = false;
            // Get Data From DB
            int y = dataGridView1.CurrentCell.RowIndex;
            int fullR = (int)opList[y].FullReport;
            if (fullR == 2)
            {
                if (FormMain.ProgramAccessLevel >= 500)
                    ButtonPrint.Enabled = true;
            }
                

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}