using SarasaviLMS.Models;
using SarasaviLMS.Services;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SarasaviLMS.UI
{
    public partial class LoginForm : Form
    {
        private readonly UserService _userService;

        public LoginForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string nic = txtNIC.Text.Trim();

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(nic))
            {
                MessageBox.Show("Please enter both Name and NIC.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Fetch user by NIC and Name
            var user = _userService.GetUserByNIC(nic);

            if (user != null && user.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;  // Set DialogResult to OK on successful login
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Name or NIC.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Show();  // Show LoginForm again after RegisterForm is closed
        }
    }
}
