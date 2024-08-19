using SarasaviLMS.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SarasaviLMS.Data
{
    internal class BookDAL
    {
        private readonly DatabaseHelper _helper;

        public BookDAL()
        {
            _helper = new DatabaseHelper();
        }

        public bool SaveBook(Book book)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO Book (Title, Author, ISBN, Publisher, Classification) VALUES (@Title, @Author, @ISBN, @Publisher, @Classification)";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", book.Title);
                        cmd.Parameters.AddWithValue("@Author", book.Author);
                        cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                        cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                        cmd.Parameters.AddWithValue("@Classification", book.Classification);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in SaveBook", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in SaveBook", ex);
                    return false;
                }
            }
        }

        public bool UpdateBook(Book book)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "UPDATE Book SET Title = @Title, Author = @Author, ISBN = @ISBN, Publisher = @Publisher, Classification = @Classification WHERE BookId = @BookId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", book.Title);
                        cmd.Parameters.AddWithValue("@Author", book.Author);
                        cmd.Parameters.AddWithValue("@ISBN", book.ISBN);
                        cmd.Parameters.AddWithValue("@Publisher", book.Publisher);
                        cmd.Parameters.AddWithValue("@Classification", book.Classification);
                        cmd.Parameters.AddWithValue("@BookId", book.BookId);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in UpdateBook", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in UpdateBook", ex);
                    return false;
                }
            }
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Book";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                books.Add(new Book
                                {
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    Title = reader["Title"].ToString(),
                                    Author = reader["Author"].ToString(),
                                    ISBN = reader["ISBN"].ToString(),
                                    Publisher = reader["Publisher"].ToString(),
                                    Classification = reader["Classification"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetAllBooks", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetAllBooks", ex);
                }
            }

            return books;
        }

        public List<Book> GetAvailableBooks()
        {
            List<Book> books = new List<Book>();

            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Book WHERE BookId IN (SELECT DISTINCT BookId FROM Copy WHERE Status = 'Available')";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                books.Add(new Book
                                {
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    Title = reader["Title"].ToString(),
                                    Author = reader["Author"].ToString(),
                                    ISBN = reader["ISBN"].ToString(),
                                    Publisher = reader["Publisher"].ToString(),
                                    Classification = reader["Classification"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetAvailableBooks", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetAvailableBooks", ex);
                }
            }

            return books;
        }


        public Book GetBookById(int id)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Book WHERE BookId = @BookId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookId", id);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new Book
                                {
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    Title = reader["Title"].ToString(),
                                    Author = reader["Author"].ToString(),
                                    ISBN = reader["ISBN"].ToString(),
                                    Publisher = reader["Publisher"].ToString(),
                                    Classification = reader["Classification"].ToString()
                                };
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetBookById", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetBookById", ex);
                }
            }
            return null;
        }

        public List<Book> GetBooksByName(string name)
        {
            List<Book> books = new List<Book>();
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM Book WHERE Title LIKE @Title";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Title", $"%{name}%");

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                books.Add(new Book
                                {
                                    BookId = Convert.ToInt32(reader["BookId"]),
                                    Title = reader["Title"].ToString(),
                                    Author = reader["Author"].ToString(),
                                    ISBN = reader["ISBN"].ToString(),
                                    Publisher = reader["Publisher"].ToString(),
                                    Classification = reader["Classification"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in GetBooksByName", ex);
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in GetBooksByName", ex);
                }
            }
            return books;
        }

        public bool DeleteBook(int id)
        {
            using (SqlConnection conn = _helper.GetConnection())
            {
                try
                {
                    conn.Open();
                    string query = "DELETE FROM Book WHERE BookId = @BookId";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@BookId", id);

                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
                catch (SqlException ex)
                {
                    LogError("SQL Error in DeleteBook", ex);
                    return false;
                }
                catch (Exception ex)
                {
                    LogError("Unexpected Error in DeleteBook", ex);
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
