using SarasaviLMS.Models;
using SarasaviLMS.Services;
using SarasaviLMS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SarasaviLMS.UI.Controls.LoanRel
{
    public partial class AddBorrowControl : UserControl
    {
        private readonly LoanService _loanService;
        private readonly BookService _bookService;
        private readonly CopyService _copyService;
        private List<Book> availableBooks;
        private List<Copy> availableCopies;

        public event Action<Loan> LoanAdded;

        public AddBorrowControl()
        {
            InitializeComponent();
            _loanService = new LoanService();
            _bookService = new BookService();
            _copyService = new CopyService();
            LoadAvailableBooks();
        }

        private void LoadAvailableBooks()
        {
            // Fetch the list of available books
            availableBooks = _bookService.GetAllBooks();

            // Populate the ComboBox with book titles
            comboBoxBookTitle.Items.Clear();
            foreach (var book in availableBooks)
            {
                comboBoxBookTitle.Items.Add(book.Title);
            }

            // Select the first item by default if available
            if (comboBoxBookTitle.Items.Count > 0)
            {
                comboBoxBookTitle.SelectedIndex = 0;
            }

            LoadAvailableCopies(); // Load copies for the first book
        }

        private void LoadAvailableCopies()
        {
            if (comboBoxBookTitle.SelectedIndex == -1) return;

            // Get the selected book
            var selectedBook = availableBooks[comboBoxBookTitle.SelectedIndex];

            // Fetch available copies of the selected book
            availableCopies = _copyService.GetAvailableCopiesByBookId(selectedBook.BookId);

            // Populate the CopyNumber ComboBox
            comboBoxCopyNumber.Items.Clear();
            foreach (var copy in availableCopies)
            {
                comboBoxCopyNumber.Items.Add(copy.CopyNumber.ToString());
            }

            // Select the first copy by default if available
            if (comboBoxCopyNumber.Items.Count > 0)
            {
                comboBoxCopyNumber.SelectedIndex = 0;
            }
        }

        private void comboBoxBookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAvailableCopies();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (comboBoxBookTitle.SelectedIndex == -1 ||
                comboBoxCopyNumber.SelectedIndex == -1)
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Find the selected book and copy
            var selectedBook = availableBooks[comboBoxBookTitle.SelectedIndex];
            var selectedCopy = availableCopies[comboBoxCopyNumber.SelectedIndex];

            // Create new Loan object
            var newLoan = new Loan
            {
                UserId = SessionManager.UserId,  // Get current user id from session
                CopyId = selectedCopy.CopyId,    // Use CopyId from the selected copy
                LoanDate = DateTime.Now,
                DueDate = datePickerDueDate.Value
            };

            // Save the loan using the LoanService
            if (_loanService.AddNewLoan(newLoan, out string errorMessage))
            {
                MessageBox.Show("Book borrowed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Trigger the event to notify the parent control
                LoanAdded?.Invoke(newLoan);

                // Optionally, clear the fields after adding
                comboBoxBookTitle.SelectedIndex = 0;
                comboBoxCopyNumber.SelectedIndex = 0;
                datePickerDueDate.Value = DateTime.Now;

                Navigator.Navigate(ParentForm, NavigationTarget.UserDashboard);
            }
            else
            {
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
