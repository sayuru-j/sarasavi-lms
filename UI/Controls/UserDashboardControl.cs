using SarasaviLMS.Utils;
using System;
using System.Windows.Forms;

namespace SarasaviLMS.UI.Controls
{
    public partial class UserDashboardControl : UserControl
    {
        public UserDashboardControl()
        {
            InitializeComponent();
            this.lblTitle.Text = $"Welcome {SessionManager.Username}!";
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(ParentForm, NavigationTarget.Borrow);
        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reserve clicked!");
        }

        private void btnInquiry_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inquiry clicked!");
        }

        private void btnMyBorrowings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Borrowings clicked!");
        }

        private void btnMyReservations_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My Reservations clicked!");
        }

        private void BtnMyInquiries_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(ParentForm, NavigationTarget.MyInquiries);
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
