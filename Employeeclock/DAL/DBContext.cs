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

        private readonly string _connectionString;
        public DBContext()
        {
            _connectionString = getconstr();
        }

        private string getconstr()
        {
            IConfiguration builder = new ConfigurationBuilder()
                .AddJsonFile("secrets.json", optional: true) 
                .Build();
            
            string connString = builder["ConnectionString"];
            if (string.IsNullOrEmpty(connString)) {
                throw new Exception("cannot read conn string from secrets");
            };
            return connString;
        }

        public DataTable MadeQuery(string querystr)
        {
            DataTable output = new DataTable();
            using (SqlConnection conn = new SqlConnection(_connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(querystr, conn))
                {
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

 }
}
