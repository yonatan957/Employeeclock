using Demo.Services;
using Employeeclock.DAL;
using Employeeclock.NewFolder;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Employeeclock
{
    public partial class PasswordChangeForm : Form
    {
        private DBContext dbContext = new DBContext();

        public PasswordChangeForm()
        {
            InitializeComponent();
        }

        private void button_ppTOlp_apruve_Click(object sender, EventArgs e)
        {
            if (textBox_OPassword.Text.Length == 0 || textBoxNPassword.Text.Length == 0 || textBoxNPassword.Text.Length == 0 || textBox_NPasswordApprove.Text.Length == 0)
            {
                MessageBox.Show("one or more properties is empty");
                return;
            }
            string np = textBoxNPassword.Text;
            string npa = textBox_NPasswordApprove.Text;
            string tz = textBox_TZ.Text;
            string op = textBox_OPassword.Text;
            try
            {
                string query = $"select p.EmployeePassword from Employees e join Passwords p ON p.EmployeeID = e.ID where p.EmployeeID = ${tz}";
                string ressult = dbContext.MadeQuery(query).Rows[0][0].ToString();
            }
            catch
            {
                MessageBox.Show("invalid ID or Password");
            }
            if (np == npa)
            {
                string query2 = $"update Passwords set EmployeePassword = {np} where EmployeeID = ${tz}";
                dbContext.MadeQuery(query2);
                NavigationService.ShowForm("ClockForm", tz);
            }
            else
            {
                MessageBox.Show("The passwords you entered do not match. Please ensure that both the new password and the confirmation password are identical. Thank you.");
            }
        }

        private void linkLabel_ppTOlp_cancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NavigationService.ShowForm("LoginpageForm");
        }

        private void PasswordChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
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
