using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text; 
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;


namespace Employeeclock.DAL
{
    public class DBContext
    {



        private string getconstr()
        {
            var config = new ConfigurationBuilder()
             .AddUserSecrets<DBContext>()
             .Build();
            string? cs = config["connectionString"];
            if (cs == null) throw new Exception("Cannot read conn striong from secrets");
            return cs;
        }

        public DataTable MadeQuery(string querystr, SqlParameter parameters = null)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(getconstr()))
            {
                using (SqlCommand cmd = new SqlCommand(querystr, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.Add(parameters);
                    }
                    try
                    {
                        conn.Open();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(output);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("An error occurred" + ex.ToString());
                    }
                }
            }
            return output;
        }
        public DataTable AproovePassword(string tz)
        {
            SqlParameter sqlParameter = new SqlParameter("@tz", tz);           
            string query = "select p.EmployeePassword from Employees e join Passwords p ON p.EmployeeID = e.ID where p.EmployeeID = @tz";
            DataTable dt = MadeQuery(query, sqlParameter);
            return dt;
        }
    }
}
