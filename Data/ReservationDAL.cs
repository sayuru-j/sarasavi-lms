using SarasaviLMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SarasaviLMS.Data
{
    internal class ReservationDAL
    {
        private readonly DatabaseHelper _helper;

        public ReservationDAL()
        {
            _helper = new DatabaseHelper();
        }

        public bool SaveReservation(Reservation reservation)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Reservation (UserId, BookId, ReservationDate, Status) VALUES (@UserId, @BookId, @ReservationDate, @Status)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", reservation.UserId);
                        cmd.Parameters.AddWithValue("@BookId", reservation.BookId);
                        cmd.Parameters.AddWithValue("@ReservationDate", reservation.ReservationDate);
                        cmd.Parameters.AddWithValue("@Status", reservation.Status);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in SaveReservation", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in SaveReservation", ex);
                    return false;
                }
            }
        }

        public bool UpdateReservation(Reservation reservation)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Reservation SET UserId = @UserId, BookId = @BookId, ReservationDate = @ReservationDate, Status = @Status WHERE ReservationId = @ReservationId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", reservation.UserId);
                        cmd.Parameters.AddWithValue("@BookId", reservation.BookId);
                        cmd.Parameters.AddWithValue("@ReservationDate", reservation.ReservationDate);
                        cmd.Parameters.AddWithValue("@Status", reservation.Status);
                        cmd.Parameters.AddWithValue("@ReservationId", reservation.ReservationId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in UpdateReservation", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in UpdateReservation", ex);
                    return false;
                }
            }
        }

        public Reservation GetReservationById(int reservationId)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Reservation WHERE ReservationId = @ReservationId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationId", reservationId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Reservation
                                {
                                    ReservationId = Convert.ToInt32(reader["ReservationId"]),
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    ReservationDate = Convert.ToDateTime(reader["ReservationDate"]),
                                    Status = reader["Status"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetReservationById", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetReservationById", ex);
                }
            }
            return null;
        }

        public List<Reservation> GetReservationsByUserId(int userId)
        {
            List<Reservation> reservations = new List<Reservation>();
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Reservation WHERE UserId = @UserId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserId", userId);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                reservations.Add(new Reservation
                                {
                                    ReservationId = Convert.ToInt32(reader["ReservationId"]),
                                    UserId = Convert.ToInt32(reader["UserId"]),
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    ReservationDate = Convert.ToDateTime(reader["ReservationDate"]),
                                    Status = reader["Status"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetReservationsByUserId", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetReservationsByUserId", ex);
                }
            }
            return reservations;
        }

        public bool DeleteReservation(int reservationId)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Reservation WHERE ReservationId = @ReservationId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@ReservationId", reservationId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in DeleteReservation", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in DeleteReservation", ex);
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
