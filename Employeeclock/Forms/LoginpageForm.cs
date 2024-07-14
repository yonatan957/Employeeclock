using Demo.Services;
using Employeeclock.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Employeeclock.NewFolder
{
    public partial class LoginpageForm : Form
    {


        private DBContext dbContext = new DBContext();


        public LoginpageForm()
        {
            InitializeComponent();
        }


        private void button_lpTOpp_Click(object sender, EventArgs e)
        {
            NavigationService.ShowForm("PasswordChangeForm");
        }

        private void button_lpTOcp_Click(object sender, EventArgs e)
        {
            string tz = textBox_tz.Text;
            string password = textBox_password.Text;
            if (tz.Length == 0 || password.Length == 0)
            {
                MessageBox.Show("one or more properties is empty");
                return;
            }
            try
            {
                string query = $"select p.EmployeePassword from Employees e join Passwords p ON p.EmployeeID = e.ID where p.EmployeeID = ${tz}";
                string ressult = dbContext.MadeQuery(query).Rows[0][0].ToString();
                if (ressult == password)
                {
                    NavigationService.ShowForm("ClockForm", tz);
                }
                else
                {
                    MessageBox.Show("invalid ID or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

      
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            if (!NavigationService.isNavigate)
            {
            Application.Exit();

            }
        }
    }
}
