using SarasaviLMS.Data;
using SarasaviLMS.Models;
using SarasaviLMS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLMS.Services
{
    internal class BookService
    {
        private readonly BookDAL _bookDAL;

        public BookService()
        {
            _bookDAL = new BookDAL();
        }

        public bool AddNewBook(Book book, out string errorMessage)
        {
            // Validate Book object
            var validationResult = ValidateBook(book);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Save the book using the DAL
            if (_bookDAL.SaveBook(book))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to save the book.";
                return false;
            }
        }

        public bool UpdateBook(Book book, out string errorMessage)
        {
            // Validate Book object
            var validationResult = ValidateBook(book);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Update the book using the DAL
            if (_bookDAL.UpdateBook(book))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to update the book.";
                return false;
            }
        }

        public List<Book> GetAllBooks()
        {
            return _bookDAL.GetAllBooks();
        }

        public List<Book> GetAvailableBooks()
        {
            // Fetch and return a list of available books
            return _bookDAL.GetAvailableBooks();
        }


        public Book GetBookById(int id)
        {
            // Fetch book by ID
            return _bookDAL.GetBookById(id);
        }

        public List<Book> GetBooksByName(string name)
        {
            // Fetch books by name
            return _bookDAL.GetBooksByName(name);
        }

        public bool DeleteBook(int id, out string errorMessage)
        {
            // Delete the book
            if (_bookDAL.DeleteBook(id))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to delete the book.";
                return false;
            }
        }

        private ValidationResult ValidateBook(Book book)
        {
            if (string.IsNullOrWhiteSpace(book.Title))
            {
                return new ValidationResult(false, "Title is required.");
            }

            if (string.IsNullOrWhiteSpace(book.Author))
            {
                return new ValidationResult(false, "Author is required.");
            }

            if (string.IsNullOrWhiteSpace(book.ISBN))
            {
                return new ValidationResult(false, "ISBN is required.");
            }

            if (string.IsNullOrWhiteSpace(book.Publisher))
            {
                return new ValidationResult(false, "Publisher is required.");
            }

            if (string.IsNullOrWhiteSpace(book.Classification))
            {
                return new ValidationResult(false, "Classification is required.");
            }

            return new ValidationResult(true, "Validation succeeded.");
        }
    }
}
