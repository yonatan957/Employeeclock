using Employeeclock.NewFolder;
using Employeeclock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employeeclock.DAL;

namespace Demo.Services
{
     internal class NavigationService
    {

        
        public DBContext dbContext = new DBContext();
        static public bool isNavigate = false;
        private static void CloseAllForms()
        {
            isNavigate = true;
            List<Form> openForms = new List<Form>(Application.OpenForms.Cast<Form>());
            foreach (Form item in openForms)
            {
                item.Close();
            }
            isNavigate = false;
        }
        public static void ShowForm(string formName, string name = "e")
        {
            CloseAllForms();
            Form form = formName switch
            {
                "PasswordChangeForm" => new PasswordChangeForm(),
                "ClockForm" => new ClockForm(name),
                "LoginpageForm" => new LoginpageForm(),
                _ => throw new ArgumentException("invalid form name.", nameof(formName)),
            };
            form.Show();
        }
    }
}

