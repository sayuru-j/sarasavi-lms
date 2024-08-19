using SarasaviLMS.Utils;
using System;
using System.Windows.Forms;

namespace SarasaviLMS.UI.Controls
{
    public partial class AdminDashboardControl : UserControl
    {
        public AdminDashboardControl()
        {
            InitializeComponent();
        }

        private void BtnManageBooks_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(ParentForm, NavigationTarget.BookManagement);
        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(ParentForm, NavigationTarget.UserManagement);
        }

        private void BtnManageLoans_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Loans clicked!");
        }

        private void BtnManageReservations_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Reservations clicked!");
        }

        private void BtnManageInquiries_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(ParentForm, NavigationTarget.InquiryManagement);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            // Clear the session and show the login form again
            SessionManager.ClearSession();

            // Close the current form and show the login form
            var parentForm = this.FindForm();
            parentForm?.Hide();

            LoginForm loginForm = new LoginForm();
            var result = loginForm.ShowDialog();

            if (result == DialogResult.OK)
            {
                // Optionally reload the main form or perform other actions on successful login
                parentForm?.Show();
            }
            else
            {
                Application.Exit(); // Close the application if login is not successful
            }
        }
    }
}
