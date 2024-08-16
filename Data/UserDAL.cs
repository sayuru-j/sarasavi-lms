using SarasaviLMS.Models;
using System;
using System.Data.SqlClient;
using System.IO;

namespace SarasaviLMS.Data
{
    internal class UserDAL
    {
        private readonly DatabaseHelper _helper;

        public UserDAL() { 
            DatabaseHelper databaseHelper = new DatabaseHelper();
            _helper = databaseHelper;
        }

        public bool SaveUser(User user)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO Users (Username, Email, PasswordHash, Role) VALUES (@Username, @Email, @PasswordHash, @Role)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", user.Username);
                        cmd.Parameters.AddWithValue("@Email", user.Email);
                        cmd.Parameters.AddWithValue("@PasswordHash", user.Password); // Assuming the password is already hashed
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

        public User GetUserByUsername(string username)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT UserID, Username, Email, PasswordHash, Role FROM Users WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new User
                                {
                                    Username = reader["Username"].ToString(),
                                    Email = reader["Email"].ToString(),
                                    Password = reader["PasswordHash"].ToString(),
                                    Role = reader["Role"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetUserByUsername", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetUserByUsername", ex);
                }
            }

            return null; // Return null if user not found or in case of an error
        }

        public bool IsEmailTaken(string email)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(1) FROM Users WHERE Email = @Email";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in IsEmailTaken", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in IsEmailTaken", ex);
                    return false;
                }
            }
        }

        public bool IsUsernameTaken(string username)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();

                    string query = "SELECT COUNT(1) FROM Users WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        int count = (int)cmd.ExecuteScalar();
                        return count > 0;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in IsUsernameTaken", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in IsUsernameTaken", ex);
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
