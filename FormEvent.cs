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
    public partial class FormEvent : Form
    {
        private BindingList<Events> evList = new BindingList<Events>();
        public FormEvent()
        {
            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSelect_Click(object sender, EventArgs e)
        {
            DateTime StartTime = dateTimePickerStart.Value;
            DateTime EndTime = dateTimePickerEnd.Value;
            SelectEventDataToGrid(StartTime, EndTime);
        }
        private void SelectEventDataToGrid(DateTime StartTime, DateTime EndTime)
        {
            evList.Clear();

            //  Check Register of Operations
            using (IluksteEntities db = new IluksteEntities())
            {
                var events = db.Events.Where(p => p.DataTime >= StartTime && p.DataTime <= EndTime).ToList();

                foreach (Events ev in events)
                {

                    evList.Add(ev);
                }
            }
        }

        private void FormEvent_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = evList;
            // Format DataGridView
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].HeaderText = "Дата/Время"; 
            dataGridView1.Columns[1].Width = 200;
            dataGridView1.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].HeaderText = "Сообщение";
            dataGridView1.Columns[3].Width = 900;
            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[4].Visible = false;


            DateTime start = DateTime.Now.AddDays(-7);
            dateTimePickerStart.Value = start;
            DateTime end = DateTime.Now;
            dateTimePickerEnd.Value = end;

            SelectEventDataToGrid(start, end);
        }
    }
}
