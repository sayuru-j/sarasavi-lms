using SarasaviLMS.Models;
using System;
using System.Data.SqlClient;
using System.IO;

namespace SarasaviLMS.Data
{
    internal class UserDAL
    {
        private readonly DatabaseHelper _helper;

        public UserDAL()
        {
            _helper = new DatabaseHelper();
        }

        public bool SaveUser(User user)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO [User] (Name, NIC, Sex, Address, Role) VALUES (@Name, @NIC, @Sex, @Address, @Role)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", user.Name);
                        cmd.Parameters.AddWithValue("@NIC", user.NIC);
                        cmd.Parameters.AddWithValue("@Sex", user.Sex);
                        cmd.Parameters.AddWithValue("@Address", user.Address);
                        cmd.Parameters.AddWithValue("@Role", user.Role);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in SaveUser", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in SaveUser", ex);
                    return false;
                }
            }
        }

        public User GetUserByNIC(string nic)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT UserId, Name, NIC, Sex, Address, Role FROM [User] WHERE NIC = @NIC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIC", nic);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    Name = reader["Name"].ToString(),
                                    NIC = reader["NIC"].ToString(),
                                    Sex = reader["Sex"].ToString(),
                                    Address = reader["Address"].ToString(),
                                    Role = reader["Role"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetUserByNIC", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetUserByNIC", ex);
                }
            }

            return null; // Return null if user not found or in case of an error
        }

        public bool IsNICUnique(string nic)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(1) FROM [User] WHERE NIC = @NIC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@NIC", nic);

                        int count = (int)cmd.ExecuteScalar();
                        return count == 0; // Return true if NIC is unique
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in IsNICUnique", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in IsNICUnique", ex);
                    return false;
                }
            }
        }

        private void LogError(string message, Exception ex)
        {
            // Simple logging to a file, you could use a logging framework like NLog or log4net for better logging capabilities
            string logFilePath = "error_log.txt"; // Define the path where you want to save your log file
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
                writer.WriteLine(ex.ToString());
                writer.WriteLine();
            }
        }
    }
}
