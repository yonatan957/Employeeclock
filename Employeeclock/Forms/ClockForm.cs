using Demo.Services;
using Employeeclock.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employeeclock.NewFolder
{

    public partial class ClockForm : Form
    {
        private DBContext dbContext = new DBContext();


        Boolean first = false;
        public string TZ;
        public string lastEntrance;
        public string lastExit;
        public ClockForm(string tZ)
        {
            InitializeComponent();
            TZ = tZ;
            FindName();
            ShowDates();
        }
        public void FindName()
        {
            string Query = $"select e.FirstName, e.LastName from Employees e where E.ID = ${TZ}";
            DataTable dataTable = dbContext.MadeQuery(Query);
            label_Name.Text = dataTable.Rows[0][0].ToString() + " " + dataTable.Rows[0][1].ToString();
        }

        public void ShowDates()
        {
            string query = $"select e.EntryTime, e.ExitTime from EmployeeAttendance e where e.EntryTime =(SELECT MAX(em.EntryTime) from Employees e join EmployeeAttendance em ON em.EmployeeCode = e.ID where e.ID = ${TZ})";
            DataTable dataTable1 = dbContext.MadeQuery(query);
            if (dataTable1.Rows.Count == 0)
            {
                first = true;
                return;
            }
            string lastEntrance = dataTable1.Rows[0][0].ToString();
            if (dataTable1.Rows[0][1] == DBNull.Value)
            {
                lastExit = "";
            }
            else
            {
                lastExit = dataTable1.Rows[0][1].ToString();
            }

            label_lastEntrance.Text = lastEntrance;
            label_LastExit.Text = lastExit;
        }

        private void button_entrance_Click(object sender, EventArgs e)
        {
            if (lastExit == "" && !first)
            {
                MessageBox.Show("your allready in!");
                return;
            }

            string query = $"insert into EmployeeAttendance(EmployeeCode, EntryTime)values(${TZ}, GETDATE())";
            dbContext.MadeQuery(query);
            MessageBox.Show("you entrance Successfully");
            Application.Exit();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            if (first)
            {
                MessageBox.Show("It's your first time, you need to get in before");
                return;
            }
            if (lastExit.Length > 0)
            {
                MessageBox.Show("your allready out");
                return;
            }
            string query = $"update EmployeeAttendance  set ExitTime = GETDATE() where EntryTime =(SELECT MAX(em.EntryTime) from Employees e join EmployeeAttendance em ON em.EmployeeCode = e.ID where e.ID = ${TZ})";
            dbContext.MadeQuery(query);
            MessageBox.Show("you exit Successfully");
            Application.Exit();
        }

        private void ClockForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
