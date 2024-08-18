using SarasaviLMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SarasaviLMS.Data
{
    internal class LoanDAL
    {
        private readonly DatabaseHelper _helper;

        public LoanDAL()
        {
            _helper = new DatabaseHelper();
        }

        public bool SaveLoan(Loan loan)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Loan (UserId, CopyId, LoanDate, DueDate) VALUES (@UserId, @CopyId, @LoanDate, @DueDate)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", loan.UserId);
                        cmd.Parameters.AddWithValue("@CopyId", loan.CopyId);
                        cmd.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
                        cmd.Parameters.AddWithValue("@DueDate", loan.DueDate);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in SaveLoan", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in SaveLoan", ex);
                    return false;
                }
            }
        }

        public bool UpdateLoan(Loan loan)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Loan SET UserId = @UserId, CopyId = @CopyId, LoanDate = @LoanDate, DueDate = @DueDate, ReturnDate = @ReturnDate WHERE LoanId = @LoanId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", loan.UserId);
                        cmd.Parameters.AddWithValue("@CopyId", loan.CopyId);
                        cmd.Parameters.AddWithValue("@LoanDate", loan.LoanDate);
                        cmd.Parameters.AddWithValue("@DueDate", loan.DueDate);
                        cmd.Parameters.AddWithValue("@ReturnDate", loan.ReturnDate.HasValue ? (object)loan.ReturnDate.Value : DBNull.Value);
                        cmd.Parameters.AddWithValue("@LoanId", loan.LoanId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in UpdateLoan", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in UpdateLoan", ex);
                    return false;
                }
            }
        }

        public Loan GetLoanById(int loanId)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Loan WHERE LoanId = @LoanId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LoanId", loanId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Loan
                                {
                                    LoanId = Convert.ToInt32(reader["LoanId"]),
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    CopyId = Convert.ToInt32(reader["CopyId"]),
                                    LoanDate = Convert.ToDateTime(reader["LoanDate"]),
                                    DueDate = Convert.ToDateTime(reader["DueDate"]),
                                    ReturnDate = reader["ReturnDate"] != DBNull.Value ? Convert.ToDateTime(reader["ReturnDate"]) : (DateTime?)null
                                };
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetLoanById", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetLoanById", ex);
                }
            }
            return null;
        }

        public List<Loan> GetLoansByUserId(int userId)
        {
            List<Loan> loans = new List<Loan>();
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Loan WHERE UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                loans.Add(new Loan
                                {
                                    LoanId = Convert.ToInt32(reader["LoanId"]),
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    CopyId = Convert.ToInt32(reader["CopyId"]),
                                    LoanDate = Convert.ToDateTime(reader["LoanDate"]),
                                    DueDate = Convert.ToDateTime(reader["DueDate"]),
                                    ReturnDate = reader["ReturnDate"] != DBNull.Value ? Convert.ToDateTime(reader["ReturnDate"]) : (DateTime?)null
                                });
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetLoansByUserId", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetLoansByUserId", ex);
                }
            }
            return loans;
        }

        public bool DeleteLoan(int loanId)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Loan WHERE LoanId = @LoanId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@LoanId", loanId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in DeleteLoan", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in DeleteLoan", ex);
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
