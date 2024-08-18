using SarasaviLMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SarasaviLMS.Data
{
    internal class CopyDAL
    {
        private readonly DatabaseHelper _helper;

        public CopyDAL()
        {
            _helper = new DatabaseHelper();
        }

        public bool SaveCopy(Copy copy)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Copy (BookId, CopyNumber, IsReference, Status) VALUES (@BookId, @CopyNumber, @IsReference, @Status)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookId", copy.BookId);
                        cmd.Parameters.AddWithValue("@CopyNumber", copy.CopyNumber);
                        cmd.Parameters.AddWithValue("@IsReference", copy.IsReference);
                        cmd.Parameters.AddWithValue("@Status", copy.Status);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in SaveCopy", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in SaveCopy", ex);
                    return false;
                }
            }
        }

        public bool UpdateCopy(Copy copy)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Copy SET BookId = @BookId, CopyNumber = @CopyNumber, IsReference = @IsReference, Status = @Status WHERE CopyId = @CopyId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookId", copy.BookId);
                        cmd.Parameters.AddWithValue("@CopyNumber", copy.CopyNumber);
                        cmd.Parameters.AddWithValue("@IsReference", copy.IsReference);
                        cmd.Parameters.AddWithValue("@Status", copy.Status);
                        cmd.Parameters.AddWithValue("@CopyId", copy.CopyId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in UpdateCopy", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in UpdateCopy", ex);
                    return false;
                }
            }
        }

        public Copy GetCopyById(int copyId)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Copy WHERE CopyId = @CopyId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CopyId", copyId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Copy
                                {
                                    CopyId = Convert.ToInt32(reader["CopyId"]),
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    CopyNumber = Convert.ToInt32(reader["CopyNumber"]),
                                    IsReference = Convert.ToBoolean(reader["IsReference"]),
                                    Status = reader["Status"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetCopyById", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetCopyById", ex);
                }
            }
            return null;
        }

        public List<Copy> GetCopiesByBookId(int bookId)
        {
            List<Copy> copies = new List<Copy>();
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Copy WHERE BookId = @BookId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookId", bookId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                copies.Add(new Copy
                                {
                                    CopyId = Convert.ToInt32(reader["CopyId"]),
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    CopyNumber = Convert.ToInt32(reader["CopyNumber"]),
                                    IsReference = Convert.ToBoolean(reader["IsReference"]),
                                    Status = reader["Status"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetCopiesByBookId", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetCopiesByBookId", ex);
                }
            }
            return copies;
        }

        public bool DeleteCopy(int copyId)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Copy WHERE CopyId = @CopyId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@CopyId", copyId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in DeleteCopy", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in DeleteCopy", ex);
                    return false;
                }
            }
        }

        private void LogError(string message, Exception ex)
        {
            // Log the error (implementation omitted for brevity)
            Console.WriteLine($"{DateTime.Now}: {message}");
            Console.WriteLine(ex.ToString());
        }
    }
}
