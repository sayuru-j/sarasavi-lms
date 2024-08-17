using SarasaviLMS.Models;
using SarasaviLMS.Services;
using System;
using System.Windows.Forms;

namespace SarasaviLMS.UI
{
    public partial class RegisterForm : Form
    {
        private UserService _userService;

        public RegisterForm()
        {
            InitializeComponent();
            UserService userService = new UserService();
            _userService = userService;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            // Create User object
            User userToAdd = new User
            {
                Username = username,
                Email = email,
                Password = password,
                Role = "User"
            };

            // Add the new user
            if (_userService.AddNewUser(userToAdd, out string errorMessage))
            {
                MessageBox.Show("Registration successful!");
                // Optionally, clear the form or redirect to a different form
            }
            else
            {
                MessageBox.Show(errorMessage, "Registration Error");
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void text_AlreadyhaveAnAccount_Click(object sender, EventArgs e)
        {
            this.Close();  // Close RegisterForm and return to LoginForm
        }
    }
}
