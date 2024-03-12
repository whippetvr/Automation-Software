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
    public partial class FormMain : Form
    {
        public static string ProgramUserName = "";
        public static short ProgramAccessLevel = 0;

        public static BindingList<SaabOPCToDataGrid> dgwOPCList = new BindingList<SaabOPCToDataGrid>();

        private int SaabAutoReadCounter = 0;
        private int SaabTimeIntervalDBCounter = 0;
        public static bool OPCDataReady = false;

        public static SaabOPCToDataGrid OPCDataList(int ID)
        {
            SaabOPCToDataGrid saab = new SaabOPCToDataGrid();

            return saab;
        }

        private void OnUserChanged(string UserName, int AccessLevel)
        {

        }

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemOper_Click(object sender, EventArgs e)
        {
            Form newForm = new FormOper
            {
                MdiParent = this
            };
            newForm.Show();
        }

        private void ToolStripMenuItemReg_Click(object sender, EventArgs e)
        {
            Form newForm = new FormReg
            {
                MdiParent = this
            };
            newForm.Show();
        }

        private void ToolStripMenuItemEvent_Click(object sender, EventArgs e)
        {
            Form newForm = new FormEvent
            {
                MdiParent = this
            };
            newForm.Show();
        }

        private void ToolStripMenuItemConf_Click(object sender, EventArgs e)
        {
            Form newForm = new FormOptions();
            newForm.Show();
        }

        private void ToolStripMenuItemLogin_Click(object sender, EventArgs e)
        {
            Form newForm = new FormLogin();
            DialogResult res = newForm.ShowDialog();
            if(res == DialogResult.OK)
            {
                // Change Statuss Strip
                toolStripStatusLabelUserName.Text = ProgramUserName;

                // Enable/disable Control
                switch(ProgramAccessLevel)
                {
                    case 0:
                        ToolStripMenuItemOper.Enabled = false;
                        ToolStripMenuItemReg.Enabled = false;
                        ToolStripMenuItemEvent.Enabled = false;
                        ToolStripMenuItemConf.Enabled = false;
                        break;
                    case 200:
                        ToolStripMenuItemOper.Enabled = true;
                        ToolStripMenuItemReg.Enabled = true;
                        ToolStripMenuItemEvent.Enabled = false;
                        ToolStripMenuItemConf.Enabled = false;
                        break;
                    case 500:
                        ToolStripMenuItemOper.Enabled = true;
                        ToolStripMenuItemReg.Enabled = true;
                        ToolStripMenuItemEvent.Enabled = true;
                        ToolStripMenuItemConf.Enabled = false;
                        break;
                    case 700:
                        ToolStripMenuItemOper.Enabled = true;
                        ToolStripMenuItemReg.Enabled = true;
                        ToolStripMenuItemEvent.Enabled = true;
                        ToolStripMenuItemConf.Enabled = true;
                        break;
                    case 1000:
                        ToolStripMenuItemOper.Enabled = true;
                        ToolStripMenuItemReg.Enabled = true;
                        ToolStripMenuItemEvent.Enabled = true;
                        ToolStripMenuItemConf.Enabled = true;
                        break;

                }
                //if (ProgramAccessLevel == 1000)
                //{
                //    ToolStripMenuItemOper.Enabled = true;
                //    ToolStripMenuItemReg.Enabled = true;
                //    ToolStripMenuItemEvent.Enabled = true;
                //    ToolStripMenuItemConf.Enabled = true;
                //}
                //else
                //{
                //    ToolStripMenuItemOper.Enabled = true;
                //    ToolStripMenuItemReg.Enabled = true;
                //    ToolStripMenuItemEvent.Enabled = true;
                //    ToolStripMenuItemConf.Enabled = false;
                //}
            }
            else
            {
                ToolStripMenuItemOper.Enabled = false;
                ToolStripMenuItemReg.Enabled = false;
                ToolStripMenuItemEvent.Enabled = false;
                ToolStripMenuItemConf.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Debug information
            //if (dgwOPCList.Count == 16 && OPCDataReady ==  false)
            //{
            //    // End to read from OPC Server
            //    foreach (SaabOPCToDataGrid sb in dgwOPCList)
            //    {
            //        listView1.Items.Add(sb.TankName + " " + sb.TankLevel.ToString() + ", " + sb.TankAvgTemp.ToString() + ", " + sb.TankDensity.ToString() + ", " + sb.TankVolume.ToString() + ", " + sb.TankMassa.ToString());
            //    }
            //    OPCDataReady = true;
            //}

            bool autoRead = Properties.Settings.Default.AutoSaabRead;
            bool dataSource = Properties.Settings.Default.SaabDataSource;

            if (autoRead == true)
            {
                if (dataSource == true) //Read Data from OPC Server
                {
                    if (SaabAutoReadCounter == 0)
                    {
                        // Read Data from OPC Server
                        //ReadDataFromOPCServer();
                        ReadSaabDataAsync();

                        SaabAutoReadCounter = Properties.Settings.Default.SaabTimeInterval;
                    }
                    else
                    {
                        SaabAutoReadCounter--;
                    }

                    if (SaabTimeIntervalDBCounter == 0)
                    {
                        SaabTimeIntervalDBCounter = Properties.Settings.Default.SaabTimeIntervalDB;

                        if (dgwOPCList.Count > 0)
                        {
                            List<SaabOPCToDataGrid> ls = dgwOPCList.ToList();
                            //dgwList = (BindingList<SaabOPCToDataGrid>)ObjectCloner.Clone(obj: FormMain.dgwOPCList);
                            System.Collections.IList list1 = ls;

                            SaveSaabToDB.SaveSaabDataToDBAsync(list1);
                        }
                    }
                    else
                    {
                        SaabTimeIntervalDBCounter--;
                    }

                }

            }

        }

        private async void ReadSaabDataAsync()
        {
            if (dgwOPCList.Count == 16)
                toolStripStatusLabelOPCState.Text = "Good";
            else
                toolStripStatusLabelOPCState.Text = "Bad";
            await Task.Run(() =>
            {
                System.Threading.Thread.Sleep(500);
                dgwOPCList.Clear();
                dgwOPCList = SaabOPCClient.ReadDataFromOPCServerAsync();
                
            }
            );
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            //listView1.Clear();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Хотите закрыть программу?", "Выход из программы", System.Windows.MessageBoxButton.YesNo) == System.Windows.MessageBoxResult.Yes)
            {
                e.Cancel = false;
            }
            else e.Cancel = true;
        }
    }
}
