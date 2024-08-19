using SarasaviLMS.Models;
using SarasaviLMS.Services;
using SarasaviLMS.Utils;
using System;
using System.Windows.Forms;

namespace SarasaviLMS.UI.Controls.InquiryRel
{
    public partial class AddInquiryControl : UserControl
    {
        public event Action<Inquiry> InquiryAdded;
        private readonly InquiryService _inquiryService;

        public AddInquiryControl()
        {
            InitializeComponent();
            _inquiryService = new InquiryService();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtUserId.Text) ||
                string.IsNullOrWhiteSpace(txtBookId.Text) ||
                string.IsNullOrWhiteSpace(txtInquiryDetails.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtUserId.Text, out int userId) || !int.TryParse(txtBookId.Text, out int bookId))
            {
                MessageBox.Show("User ID and Book ID must be valid integers.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Create a new Inquiry object
            var newInquiry = new Inquiry
            {
                UserId = userId,
                BookId = bookId,
                InquiryDate = DateTime.Now,
                InquiryDetails = txtInquiryDetails.Text.Trim()
            };

            // Save the inquiry
            if (_inquiryService.AddNewInquiry(newInquiry, out string errorMessage))
            {
                MessageBox.Show("Inquiry saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                InquiryAdded?.Invoke(newInquiry);

                // Optionally, clear the fields after saving
                txtUserId.Clear();
                txtBookId.Clear();
                txtInquiryDetails.Clear();
            }
            else
            {
                MessageBox.Show(errorMessage, "Error Saving Inquiry", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(ParentForm, NavigationTarget.UserDashboard);
        }
    }
}
