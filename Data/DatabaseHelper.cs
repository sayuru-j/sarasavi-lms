using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLMS.Data
{
    internal class DatabaseHelper
    {
        private readonly string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SarasaviDBConnectionString"].ConnectionString;

        public bool TestConnection()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Log or handle the error
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
