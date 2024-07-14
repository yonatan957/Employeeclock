using Employeeclock.DAL;
using Employeeclock.NewFolder;
using Microsoft.Extensions.Configuration;


namespace Employeeclock
{
    internal static class Program
    {
        
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var LP = new LoginpageForm();
            LP.Show();
            // SET SECRETS.JSON TO COPY ALWAYS AFTER ADDING!!
            
            Application.Run();
        }
    }
}