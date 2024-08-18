using SarasaviLMS.Models;
using SarasaviLMS.Services;
using System;
using System.Windows.Forms;

namespace SarasaviLMS.UI.Controls
{
    public partial class AddBookControl : UserControl
    {
        public event Action<Book> BookAdded;
        public event Action<Book> BookUpdated;

        private readonly BookService bookService;
        private readonly Book currentBook; // Holds the book being updated

        public AddBookControl(Book book = null) // Optional book parameter for updating
        {
            InitializeComponent();
            bookService = new BookService();

            if (book != null)
            {
                currentBook = book;
                PopulateFieldsForUpdate(); // Populate fields if it's an update
            }
        }

        private void PopulateFieldsForUpdate()
        {
            txtTitle.Text = currentBook.Title;
            txtAuthor.Text = currentBook.Author;
            txtISBN.Text = currentBook.ISBN;
            txtPublisher.Text = currentBook.Publisher;
            txtClassification.Text = currentBook.Classification;
            btnSave.Text = "Update Book"; // Change button text to reflect update action
            lblFormTitle.Text = "Update Books";
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            ReturnToBookManagementControl();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
                string.IsNullOrWhiteSpace(txtAuthor.Text) ||
                string.IsNullOrWhiteSpace(txtISBN.Text) ||
                string.IsNullOrWhiteSpace(txtPublisher.Text) ||
                string.IsNullOrWhiteSpace(txtClassification.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Determine if we're adding a new book or updating an existing one
            if (currentBook == null)
            {
                // Adding a new book
                var newBook = new Book
                {
                    Title = txtTitle.Text.Trim(),
                    Author = txtAuthor.Text.Trim(),
                    ISBN = txtISBN.Text.Trim(),
                    Publisher = txtPublisher.Text.Trim(),
                    Classification = txtClassification.Text.Trim()
                };

                if (bookService.AddNewBook(newBook, out string errMsg))
                {
                    BookAdded?.Invoke(newBook);
                    ReturnToBookManagementControl();
                }
                else
                {
                    MessageBox.Show($"Failed to add book: {errMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // Updating an existing book
                currentBook.Title = txtTitle.Text.Trim();
                currentBook.Author = txtAuthor.Text.Trim();
                currentBook.ISBN = txtISBN.Text.Trim();
                currentBook.Publisher = txtPublisher.Text.Trim();
                currentBook.Classification = txtClassification.Text.Trim();

                if (bookService.UpdateBook(currentBook, out string errMsg))
                {
                    BookUpdated?.Invoke(currentBook);
                    ReturnToBookManagementControl();
                }
                else
                {
                    MessageBox.Show($"Failed to update book: {errMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnToBookManagementControl()
        {
            // Replace AddBookControl with a new instance of BookManagementControl
            if (this.Parent is Form parentForm)
            {
                var bookManagementControl = new BookManagementControl
                {
                    Dock = DockStyle.Fill
                };

                this.Parent.Controls.Remove(this);
                parentForm.Controls.Add(bookManagementControl);
                bookManagementControl.BringToFront();
            }
        }
    }
}
