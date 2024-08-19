using SarasaviLMS.Models;
using SarasaviLMS.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SarasaviLMS.UI.Controls
{
    public partial class InquiryManagementControl : UserControl
    {
        private readonly InquiryService _inquiryService;
        private List<Inquiry> inquiries;

        public InquiryManagementControl()
        {
            InitializeComponent();
            _inquiryService = new InquiryService();
            LoadInquiries();
        }

        private void LoadInquiries()
        {
            // Fetch all inquiries ordered by InquiryDate descending (latest to oldest)
            inquiries = _inquiryService.GetAllInquiries().OrderByDescending(i => i.InquiryDate).ToList();

            // Clear existing controls
            flowLayoutPanelInquiries.Controls.Clear();

            // Populate the inquiries
            foreach (var inquiry in inquiries)
            {
                var inquiryItem = CreateInquiryItemControl(inquiry);
                flowLayoutPanelInquiries.Controls.Add(inquiryItem);
            }
        }

        private Control CreateInquiryItemControl(Inquiry inquiry)
        {
            var panel = new Panel
            {
                Width = flowLayoutPanelInquiries.Width - 25,
                Height = 60,
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(10),
                Margin = new Padding(5)
            };

            var lblDetails = new Label
            {
                Text = $"{inquiry.InquiryDate.ToShortDateString()} - {inquiry.InquiryDetails}",
                AutoSize = true,
                Location = new System.Drawing.Point(10, 10)
            };

            var btnSolved = new Button
            {
                Text = "Solved",
                AutoSize = true,
                Location = new System.Drawing.Point(panel.Width - 100, 10)
            };
            btnSolved.Click += (sender, e) => SolveInquiry(inquiry);

            panel.Controls.Add(lblDetails);
            panel.Controls.Add(btnSolved);

            return panel;
        }

        private void SolveInquiry(Inquiry inquiry)
        {
            var result = MessageBox.Show("Are you sure this inquiry is solved?", "Confirm Solve", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Remove the inquiry
                if (_inquiryService.DeleteInquiry(inquiry.InquiryId, out string errorMessage))
                {
                    MessageBox.Show("Inquiry marked as solved and deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInquiries(); // Reload the list of inquiries
                }
                else
                {
                    MessageBox.Show($"Failed to delete inquiry: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
