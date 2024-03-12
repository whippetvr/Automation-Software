using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using System.Threading;

namespace Lrt_Ilukste
{
    public partial class FormOptions : Form
    {
        private int TankID = 0;
        private string TankName = "";
        private bool CalibrIsNew = false;

        private BindingList<CoefTank> coefTList = new BindingList<CoefTank>();
        private BindingList<ZoneTank> coefZList = new BindingList<ZoneTank>();
        private BindingList<CoefTank> coefTNewList = new BindingList<CoefTank>();
        private BindingList<ZoneTank> coefZNewList = new BindingList<ZoneTank>();

        private BindingList<Users> UserList = new BindingList<Users>();

        private BindingList<Persons> PersonList = new BindingList<Persons>();


        public FormOptions()
        {
            InitializeComponent();
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
            using (IluksteEntities db = new IluksteEntities())
            {
                // Get Users from DB

                // Fill Combo Box Partner
                var part = db.Partners.ToList();
                for (int i = 0; i < part.Count; i++)
                {
                    comboBoxPartnerName.Items.Add(part[i].PartName);
                }
                comboBoxPartnerName.SelectedIndex = 0;
                // Fill Combo Box Tank
                var tank = db.Tanks.ToList();
                for (int i = 0; i < tank.Count; i++)
                {
                    comboBoxTank.Items.Add(tank[i].TankName);
                }
                comboBoxTank.SelectedIndex = 0;
                if (tank.Count > 0)
                {
                    TankID = tank[0].TankID;
                    TankName = tank[0].TankName;
                }
            }

            openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            dataGridView1.DataSource = coefTList;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[2].HeaderText = "Пояс";
            dataGridView1.Columns[3].HeaderText = "Уровень, мм";
            dataGridView1.Columns[4].HeaderText = "Объём, м³";
            dataGridView1.Columns[2].Width = 70;
            dataGridView1.Columns[3].Width = 80;
            dataGridView1.Columns[4].Width = 90;

            dataGridView2.DataSource = coefZList;
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[1].Visible = false;
            dataGridView2.Columns[2].HeaderText = "Пояс";
            dataGridView2.Columns[3].HeaderText = "Уровень, мм";
            dataGridView2.Columns[4].HeaderText = "Объём, м³";
            dataGridView2.Columns[2].Width = 70;
            dataGridView2.Columns[3].Width = 80;
            dataGridView2.Columns[4].Width = 90;

            dataGridView3.DataSource = coefTNewList;
            dataGridView3.Columns[0].Visible = false;
            dataGridView3.Columns[1].Visible = false;
            dataGridView3.Columns[2].HeaderText = "Пояс";
            dataGridView3.Columns[3].HeaderText = "Поправка, мм";
            dataGridView3.Columns[4].HeaderText = "Объём, м³";
            dataGridView3.Columns[2].Width = 70;
            dataGridView3.Columns[3].Width = 80;
            dataGridView3.Columns[4].Width = 90;

            dataGridView4.DataSource = coefZNewList;
            dataGridView4.Columns[0].Visible = false;
            dataGridView4.Columns[1].Visible = false;
            dataGridView4.Columns[2].HeaderText = "Пояс";
            dataGridView4.Columns[3].HeaderText = "Поправка, мм";
            dataGridView4.Columns[4].HeaderText = "Объём, м³";
            dataGridView4.Columns[2].Width = 70;
            dataGridView4.Columns[3].Width = 80;
            dataGridView4.Columns[4].Width = 90;

            dataGridView5.DataSource = UserList;
            dataGridView5.Columns[0].Visible = false;
            dataGridView5.Columns[1].HeaderText = "Пользователь";
            dataGridView5.Columns[1].Width = 170;
            dataGridView5.Columns[2].Visible = false;
            dataGridView5.Columns[3].Visible = false;
            dataGridView5.Columns[4].Visible = false;

            dataGridView6.DataSource = PersonList;
            dataGridView6.Columns[0].Visible = false;
            dataGridView6.Columns[1].HeaderText = "Фамилия";
            dataGridView6.Columns[1].Width = 150;
            dataGridView6.Columns[2].HeaderText = "Имя";
            dataGridView6.Columns[2].Width = 150;
            dataGridView6.Columns[3].Visible = false;
            dataGridView6.Columns[4].Visible = false;
            dataGridView6.Columns[5].Visible = false;
            dataGridView6.Columns[6].Visible = false;
            dataGridView6.Columns[7].Visible = false;

            textBoxSaabTimeInterval.Text = Properties.Settings.Default.SaabTimeInterval.ToString();
            textBoxSaabTimeIntervalDB.Text = Properties.Settings.Default.SaabTimeIntervalDB.ToString();
            checkBoxAutoSaabRead.Checked = Properties.Settings.Default.AutoSaabRead;

            if (Properties.Settings.Default.SaabDataSource == true)
                radioButtonOPC.Checked = true;
            else
                radioButtonDB.Checked = true;


        }

        private void ButtonCreate_Click(object sender, EventArgs e)
        {
            //string[] strValues1 = System.Configuration.ConfigurationSettings.AppSettings.GetValues("connectionStrings");
            //var connectionString = ConfigurationManager.ConnectionStrings["IluksteEntities"].ConnectionString;


        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Calibration Data was changed
            if (CalibrIsNew == true)
            {
                var result = MessageBox.Show("Желаете сохранить данные калибровки?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    SaveCalibrationData();
                }
                CalibrIsNew = false;
                coefTNewList.Clear();
            }

            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    // Connection string
                    break;
                case 1:
                    // Tanks calibration
                    //  Prepare Edit Form for Register of Operations
                    using (IluksteEntities db = new IluksteEntities())
                    {
                        // Get Users from DB

                        // Fill Combo Box Provider
                        var tank = db.Tanks.Where(p => p.TankName == comboBoxTank.Text).ToList();
                        if (tank.Count > 0)
                        {
                            if (TankID != tank[0].TankID)
                            {
                                coefTList.Clear();
                                var calibr = db.CoefTank.Where(p => p.TankID == TankID).ToList();
                                foreach (CoefTank c in calibr)
                                {

                                    coefTList.Add(c);
                                }
                            }

                        }

                    }
                    break;
                case 2:
                    // Users
                    using (IluksteEntities db = new IluksteEntities())
                    {
                        // Get Users from DB

                        // Fill Combo Box Provider
                        var users = db.Users.ToList();
                        if (users.Count > 0)
                        {
                            UserList.Clear();
                            foreach (Users u in users)
                            {
                                UserList.Add(u);
                            }
                        }
                    }
                    break;
                case 3:
                    // Provider - Customer
                    break;
                default:

                    break;
            }
        }

        private void comboBoxTank_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (IluksteEntities db = new IluksteEntities())
            {
                // Get Users from DB

                // Fill Combo Box Provider
                if (TankName != comboBoxTank.Text)
                {
                    coefTNewList.Clear();
                    coefZNewList.Clear();

                    var tank = db.Tanks.Where(p => p.TankName == (string)comboBoxTank.Text).ToList();
                    if (tank.Count > 0)
                    {
                        TankID = (int)tank[0].TankID;
                        coefTList.Clear();
                        var calibr = db.CoefTank.Where(p => p.TankID == TankID).OrderBy(p => p.H_Level).ToList();
                        foreach (CoefTank c in calibr)
                        {

                            coefTList.Add(c);
                        }
                        coefZList.Clear();
                        var zone = db.ZoneTank.Where(p => p.TankID == TankID).ToList();
                        foreach (ZoneTank z in zone)
                        {

                            coefZList.Add(z);
                        }

                    }
                    TankName = comboBoxTank.Text;
                }

            }
        }

        private void ButtonReadFile_Click(object sender, EventArgs e)
        {


            //if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            //    return;
            //// получаем выбранный файл
            //string filename = openFileDialog1.FileName;

            string filename = "";
            string safefilename = "";

            Thread t = new Thread((ThreadStart)(() => {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();

                openFileDialog1.Filter = "TEXT Files (*.txt)|*.txt";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;
                    safefilename = openFileDialog1.SafeFileName;
                }
            }));

            // Run your code from a thread that joins the STA Thread
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

            if (filename.Length == 0)
                return;

            // "C:\\Work\\Temp\\Lrt\\Tank05.txt"

            // читаем файл в строку
            //string fileText =  File.ReadAllText(filename);

            string dir = "";
            string[] subs = filename.Split('\\');
            for (int i = 0; i < subs.Length - 1; i++)
            {
                dir += subs[i] + "\\";
            }


            var Tlines = from file in Directory.EnumerateFiles(dir, safefilename)
                         from line in File.ReadLines(file)
                         select new
                         {
                             TLine = line
                         };


            coefTNewList.Clear();
            int idx = 0;

            foreach (var l in Tlines)
            {
                CoefTank coef = new CoefTank();
                string[] tank = l.TLine.Split(',');
                if (tank[0] != TankName.Substring(1))
                {
                    var result = MessageBox.Show("В файле < " + safefilename + " > \r нет данных по резервуару " + TankName, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                idx++;
                //coef.CoefTankID = idx;
                coef.TankID = System.Convert.ToInt16(tank[0]);
                coef.Zone = System.Convert.ToInt16(tank[1]);
                coef.H_Level = System.Convert.ToDouble(tank[2]);
                coef.V_Base = System.Convert.ToDouble(tank[3]);
                coefTNewList.Add(coef);
            }

            string zoneFile = safefilename.Replace("Tank", "Zone");
            var Zlines = from file in Directory.EnumerateFiles(dir, zoneFile)
                         from line in File.ReadLines(file)
                         select new
                         {
                             ZLine = line
                         };


            coefZNewList.Clear();
            idx = 0;

            foreach (var l in Zlines)
            {
                ZoneTank zone = new ZoneTank();
                string[] tank = l.ZLine.Split(',');
                if (tank[0] != TankName.Substring(1))
                {
                    var result = MessageBox.Show("В файле < " + zoneFile + " > \r нет данных по резервуару " + TankName, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                idx++;
                //coef.CoefTankID = idx;
                zone.TankID = System.Convert.ToByte(tank[0]);
                zone.Zone = System.Convert.ToByte(tank[1]);
                zone.HA_Level = System.Convert.ToInt16(tank[2]);
                zone.VA_Base = System.Convert.ToDouble(tank[3]);
                coefZNewList.Add(zone);
                CalibrIsNew = true;
            }
        }

        private void SaveCalibrationData()
        {

            using (IluksteEntities db = new IluksteEntities())
            {
                var tanks = db.CoefTank.Where(p => p.TankID == TankID).ToList();
                if (tanks.Count > 0)
                {
                    db.CoefTank.RemoveRange(tanks);
                    db.SaveChanges();
                }
                foreach (CoefTank c in coefTNewList)
                {
                    db.CoefTank.Add(c);
                }
                db.SaveChanges();

                var zones = db.ZoneTank.Where(p => p.TankID == TankID).ToList();
                if (zones.Count > 0)
                {
                    db.ZoneTank.RemoveRange(zones);
                    db.SaveChanges();
                }
                foreach (ZoneTank z in coefZNewList)
                {
                    db.ZoneTank.Add(z);
                }
                db.SaveChanges();
            }

            coefTList.Clear();
            foreach (CoefTank ct in coefTNewList)
            {
                coefTList.Add(ct);
            }
            dataGridView1.Refresh();

            coefZList.Clear();
            foreach (ZoneTank zt in coefZNewList)
            {
                coefZList.Add(zt);
            }
            dataGridView2.Refresh();

            coefTNewList.Clear();
            dataGridView3.Refresh();

            coefZNewList.Clear();
            dataGridView4.Refresh();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridView5.CurrentCell.RowIndex;

            string UserName = UserList[idx].UserName;
            using (IluksteEntities db = new IluksteEntities())
            {
                var users = db.Users.Where(p => p.UserName == UserName).ToList();
                if (users.Count > 0)
                {
                    textBoxUserName.Text = users[0].UserName;
                    textBoxPassword.Text = users[0].UserPWD;
                    short AccessLevel = (short)users[0].AccessLevel;
                    switch (AccessLevel)
                    {
                        case 0:
                            radioButtonaAccessNo.Checked = true;
                            break;

                        case 200:
                            radioButtonAccessPartner.Checked = true;
                            break;

                        case 500:
                            radioButtonAccessOperator.Checked = true;
                            break;

                        case 700:
                            radioButtonAccessDispatcher.Checked = true;
                            break;

                        case 1000:
                            radioButtonAccessAdmininistrator.Checked = true;
                            break;
                    }
                }
            }
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            using (IluksteEntities db = new IluksteEntities())
            {
                Users user = new Users();
                user.UserName = textBoxUserName.Text;
                user.UserPWD = FormLogin.XORText(textBoxPassword.Text);
                if (radioButtonaAccessNo.Checked)
                    user.AccessLevel = 0;
                if (radioButtonAccessPartner.Checked)
                    user.AccessLevel = 200;
                if (radioButtonAccessOperator.Checked)
                    user.AccessLevel = 500;
                if (radioButtonAccessDispatcher.Checked)
                    user.AccessLevel = 700;
                if (radioButtonAccessAdmininistrator.Checked)
                    user.AccessLevel = 1000;

                var users = db.Users.Add(user);
                db.SaveChanges();

                UserList.Add(user);
            }
        }

        private void buttonChangeUser_Click(object sender, EventArgs e)
        {
            //DataGridView5 dg = (DataGridView)sender;
            int idx = dataGridView5.CurrentCell.RowIndex;
            int UserID= UserList[idx].UserID;
            using (IluksteEntities db = new IluksteEntities())
            {
                Users users = db.Users.Where(p => p.UserID == UserID).FirstOrDefault();
                if (users != null)
                {
                    users.UserName = textBoxUserName.Text;
                    users.UserPWD = FormLogin.XORText(textBoxPassword.Text);
                    if (radioButtonaAccessNo.Checked)
                        users.AccessLevel = 0;
                    if (radioButtonAccessPartner.Checked)
                        users.AccessLevel = 200;
                    if (radioButtonAccessOperator.Checked)
                        users.AccessLevel = 500;
                    if (radioButtonAccessDispatcher.Checked)
                        users.AccessLevel = 700;
                    if (radioButtonAccessAdmininistrator.Checked)
                        users.AccessLevel = 1000;
                    db.SaveChanges();
                }
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Желаете удалить запись?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                int i = dataGridView5.CurrentCell.RowIndex;

                int idx = dataGridView5.CurrentCell.RowIndex;
                int UserID = UserList[idx].UserID;
                using (IluksteEntities db = new IluksteEntities())
                {
                    var users = db.Users.Where(p => p.UserID == UserID).ToList();
                    if (users.Count > 0)
                    {
                        db.Users.Remove(users[0]);
                        db.SaveChanges();
                    }
                }
                UserList.RemoveAt(i);
                dataGridView5.Refresh();
                textBoxUserName.Text = "";
                textBoxPassword.Text = "";
                radioButtonaAccessNo.Checked = true;
            }

        }

        private void ButtonSaveCalibration_Click(object sender, EventArgs e)
        {

            // Calibration Data was changed
            if (CalibrIsNew == true)
            {
                SaveCalibrationData();
                CalibrIsNew = false;
            }

        }

        private void comboBoxPartnerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            PersonList.Clear();
            string PartnerName = comboBoxPartnerName.Text;
            using (IluksteEntities db = new IluksteEntities())
            {
                var part = db.Partners.Where(p => p.PartName == PartnerName).ToList();
                if (part.Count > 0)
                {
                    int PartID = part[0].PartID;
                    var pers = db.Persons.Where(p => p.PartID == PartID).ToList();
                    foreach (Persons p in pers)
                    {
                        PersonList.Add(p);
                    }
                }

            }
        }

        private void dataGridView6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = dataGridView6.CurrentCell.RowIndex;
            int PersID = PersonList[idx].PersID;

            using (IluksteEntities db = new IluksteEntities())
            {
                var pers = db.Persons.Where(p => p.PersID == PersID).ToList();
                if (pers.Count > 0)
                {
                    textBoxPersonName.Text = pers[0].PersName;
                    textBoxPersonSurname.Text = pers[0].PersSurn;
                    checkBoxActivity.Checked = (bool)pers[0].PersActivity;
                }
            }
        }


        private void buttonNewPartner_Click(object sender, EventArgs e)
        {
            using (IluksteEntities db = new IluksteEntities())
            {
                var part = db.Partners.Where(p => p.PartName == comboBoxPartnerName.Text).ToList();
                if (part.Count > 0)
                {
                    int PartID = part[0].PartID;

                    Persons person = new Persons();
                    person.PartID = PartID;
                    person.PersName = textBoxPersonName.Text;
                    person.PersSurn = textBoxPersonSurname.Text;
                    person.PersActivity = checkBoxActivity.Checked;

                    var pers = db.Persons.Add(person);
                    db.SaveChanges();

                    PersonList.Add(person);
                }
            }
        }

        private void buttonChangePartner_Click(object sender, EventArgs e)
        {
            int idx = dataGridView6.CurrentCell.RowIndex;
            int PersID = PersonList[idx].PersID; ;
            using (IluksteEntities db = new IluksteEntities())
            {
                Persons pers = db.Persons.Where(p => p.PersID == PersID).FirstOrDefault();
                if (pers != null)
                {
                    pers.PersName = textBoxPersonName.Text;
                    pers.PersSurn = textBoxPersonSurname.Text;
                    pers.PersActivity = checkBoxActivity.Checked;
                    db.SaveChanges();

                    PersonList[idx].PersName = textBoxPersonName.Text;
                    PersonList[idx].PersSurn = textBoxPersonSurname.Text;
                    PersonList[idx].PersActivity = checkBoxActivity.Checked;
                    dataGridView6.Refresh();
                }
            }
        }

        private void buttonSaveConfiguration_Click(object sender, EventArgs e)
        {
            if (textBoxSaabTimeInterval.Text.Length > 0)
                Properties.Settings.Default.SaabTimeInterval = Convert.ToInt32(textBoxSaabTimeInterval.Text);

            if (textBoxSaabTimeIntervalDB.Text.Length > 0)
                Properties.Settings.Default.SaabTimeIntervalDB = Convert.ToInt32(textBoxSaabTimeIntervalDB.Text);

            Properties.Settings.Default.AutoSaabRead = checkBoxAutoSaabRead.Checked;

            if (radioButtonOPC.Checked)
                Properties.Settings.Default.SaabDataSource = true;
            if (radioButtonDB.Checked)
                Properties.Settings.Default.SaabDataSource = false;

            Properties.Settings.Default.Save();
        }
    }
}
