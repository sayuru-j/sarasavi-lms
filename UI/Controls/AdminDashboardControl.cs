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

        private void btnManageBooks_Click(object sender, EventArgs e)
        {
            LoadBookManagementControl();
        }

        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Users clicked!");
        }

        private void btnManageLoans_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Loans clicked!");
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Reservations clicked!");
        }

        private void btnManageInquiries_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Manage Inquiries clicked!");
        }

        private void LoadBookManagementControl()
        {
            // Create an instance of the BookManagementControl
            BookManagementControl bookManagementControl = new BookManagementControl
            {
                Dock = DockStyle.Fill
            };

            // Clear the current controls and add the BookManagementControl
            var parentForm = this.FindForm() as MainForm;
            parentForm?.ClearAndAddControl(bookManagementControl);
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
