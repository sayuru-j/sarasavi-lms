using SarasaviLMS.Models;
using SarasaviLMS.Services;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SarasaviLMS.UI
{
    public partial class RegisterForm : Form
    {
        private readonly UserService _userService;

        public RegisterForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string nic = txtNIC.Text.Trim();
            string sex = txtSex.Text.Trim();
            string address = txtAddress.Text.Trim();
            string role = "User";  // Default role as 'User'

            // Create User object
            User userToAdd = new User
            {
                Name = name,
                NIC = nic,
                Sex = sex,
                Address = address,
                Role = role
            };

            // Add the new user
            if (_userService.AddNewUser(userToAdd, out string errorMessage))
            {
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Optionally, clear the form or close it
                this.Close();
            }
            else
            {
                MessageBox.Show(errorMessage, "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void text_AlreadyHaveAnAccount_Click(object sender, EventArgs e)
        {
            this.Close();  // Close RegisterForm and return to LoginForm
        }
    }
}
