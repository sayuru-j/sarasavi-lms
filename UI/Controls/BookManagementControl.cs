using SarasaviLMS.Models;
using SarasaviLMS.Services;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SarasaviLMS.UI.Controls
{
    public partial class BookManagementControl : UserControl
    {
        private List<Book> books;
        private BookService _bookService;

        public BookManagementControl()
        {
            InitializeComponent();

            _bookService = new BookService();

            LoadAllBooks();  // Load all books initially
        }

        private void LoadAllBooks()
        {
            books = _bookService.GetAllBooks();  // Fetch all books from the database
            LoadBooks(books);  // Load them into the UI
        }

        private void LoadBooks(List<Book> books)
        {
            flowLayoutPanelBooks.Controls.Clear();

            foreach (var book in books)
            {
                var bookItemControl = new BookItemControl(book.Title, book.Author, book.ISBN, book.Publisher, book.Classification);
                bookItemControl.OnUpdateClicked += () => UpdateBook(book);
                bookItemControl.OnDeleteClicked += () => DeleteBook(book);
                flowLayoutPanelBooks.Controls.Add(bookItemControl);
            }
        }

        private void BtnAddNewBook_Click(object sender, EventArgs e)
        {
            var newBookControl = new AddBookControl();
            newBookControl.BookAdded += (newBook) =>
            {
                books.Add(newBook); // Add the new book to the list
                LoadBooks(books); // Refresh the book list
            };

            this.Parent.Controls.Add(newBookControl);
            newBookControl.Dock = DockStyle.Fill;  // Make sure the new control fills the parent
            this.Visible = false; // Hide the current control
        }

        private void TxtSearchBar_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtSearchBar.Text.Trim();
            var filteredBooks = books
                .Where(book => book.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            LoadBooks(filteredBooks); // Refresh the book list with the filtered result
        }

        private void UpdateBook(Book book)
        {
            var updateBookControl = new AddBookControl(book);
            updateBookControl.BookUpdated += (updatedBook) =>
            {
                books = books.Select(b => b.BookId == updatedBook.BookId ? updatedBook : b).ToList();
                LoadBooks(books); // Refresh the book list
            };

            this.Parent.Controls.Add(updateBookControl);
            updateBookControl.Dock = DockStyle.Fill;
            this.Visible = false; // Hide the current control
        }


        private void DeleteBook(Book book)
        {
            // Logic for deleting the book
            MessageBox.Show($"Delete book: {book.Title}");

            if (_bookService.DeleteBook(book.BookId, out string errorMessage))
            {
                books = books.Where(b => b.BookId != book.BookId).ToList();
                LoadBooks(books); // Refresh the book list
            }
            else
            {
                MessageBox.Show($"Failed to delete book: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
