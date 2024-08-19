using SarasaviLMS.Models;
using SarasaviLMS.Services;
using SarasaviLMS.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SarasaviLMS.UI.Controls.InquiryRel
{
    public partial class MyInquiriesControl : UserControl
    {
        private readonly InquiryService _inquiryService;
        private List<Inquiry> inquiries;

        public MyInquiriesControl()
        {
            InitializeComponent();
            _inquiryService = new InquiryService();
            LoadUserInquiries();
        }

        private void LoadUserInquiries()
        {
            int userId = SessionManager.UserId;
            if (userId <= 0)
            {
                MessageBox.Show("User not logged in. Please log in to view your inquiries.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fetch inquiries for the logged-in user
            inquiries = _inquiryService.GetInquiriesByUserId(userId).OrderByDescending(i => i.InquiryDate).ToList();

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

            panel.Controls.Add(lblDetails);

            return panel;
        }

        private void btnAddNewInquiry_Click(object sender, EventArgs e)
        {
            // Code to load the control for adding a new inquiry
            var addInquiryControl = new AddInquiryControl();
            addInquiryControl.InquiryAdded += (newInquiry) =>
            {
                inquiries.Add(newInquiry); // Add the new inquiry to the list
                LoadUserInquiries(); // Refresh the inquiries list
            };
            this.Parent.Controls.Add(addInquiryControl);
            this.Visible = false; // Hide the current control
        }
    }
}
