using SarasaviLMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SarasaviLMS.Data
{
    internal class InquiryDAL
    {
        private readonly DatabaseHelper _helper;

        public InquiryDAL()
        {
            _helper = new DatabaseHelper();
        }

        public bool SaveInquiry(Inquiry inquiry)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Inquiry (UserId, BookId, InquiryDate, InquiryDetails) VALUES (@UserId, @BookId, @InquiryDate, @InquiryDetails)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", inquiry.UserId);
                        cmd.Parameters.AddWithValue("@BookId", inquiry.BookId);
                        cmd.Parameters.AddWithValue("@InquiryDate", inquiry.InquiryDate);
                        cmd.Parameters.AddWithValue("@InquiryDetails", inquiry.InquiryDetails);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in SaveInquiry", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in SaveInquiry", ex);
                    return false;
                }
            }
        }

        public bool UpdateInquiry(Inquiry inquiry)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Inquiry SET UserId = @UserId, BookId = @BookId, InquiryDate = @InquiryDate, InquiryDetails = @InquiryDetails WHERE InquiryId = @InquiryId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", inquiry.UserId);
                        cmd.Parameters.AddWithValue("@BookId", inquiry.BookId);
                        cmd.Parameters.AddWithValue("@InquiryDate", inquiry.InquiryDate);
                        cmd.Parameters.AddWithValue("@InquiryDetails", inquiry.InquiryDetails);
                        cmd.Parameters.AddWithValue("@InquiryId", inquiry.InquiryId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in UpdateInquiry", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in UpdateInquiry", ex);
                    return false;
                }
            }
        }

        public Inquiry GetInquiryById(int inquiryId)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Inquiry WHERE InquiryId = @InquiryId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InquiryId", inquiryId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Inquiry
                                {
                                    InquiryId = Convert.ToInt32(reader["InquiryId"]),
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    InquiryDate = Convert.ToDateTime(reader["InquiryDate"]),
                                    InquiryDetails = reader["InquiryDetails"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetInquiryById", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetInquiryById", ex);
                }
            }
            return null;
        }

        public List<Inquiry> GetInquiriesByUserId(int userId)
        {
            List<Inquiry> inquiries = new List<Inquiry>();
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Inquiry WHERE UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                inquiries.Add(new Inquiry
                                {
                                    InquiryId = Convert.ToInt32(reader["InquiryId"]),
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    InquiryDate = Convert.ToDateTime(reader["InquiryDate"]),
                                    InquiryDetails = reader["InquiryDetails"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetInquiriesByUserId", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetInquiriesByUserId", ex);
                }
            }
            return inquiries;
        }

        public List<Inquiry> GetAllInquiries()
        {
            List<Inquiry> inquiries = new List<Inquiry>();
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Inquiry ORDER BY InquiryDate DESC";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                inquiries.Add(new Inquiry
                                {
                                    InquiryId = Convert.ToInt32(reader["InquiryId"]),
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    InquiryDate = Convert.ToDateTime(reader["InquiryDate"]),
                                    InquiryDetails = reader["InquiryDetails"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetAllInquiries", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetAllInquiries", ex);
                }
            }
            return inquiries;
        }

        public bool DeleteInquiry(int inquiryId)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Inquiry WHERE InquiryId = @InquiryId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@InquiryId", inquiryId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in DeleteInquiry", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in DeleteInquiry", ex);
                    return false;
                }
            }
        }

        private void LogError(string message, Exception ex)
        {
            // Simple logging to a file, you could use a logging framework like NLog or log4net for better logging capabilities
            string logFilePath = "error_log.txt"; // Define the path where you want to save your log file
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(logFilePath, true))
            {
                writer.WriteLine($"{DateTime.Now}: {message}");
                writer.WriteLine(ex.ToString());
                writer.WriteLine();
            }
        }
    }
}
