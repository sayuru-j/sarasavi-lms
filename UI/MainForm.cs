using SarasaviLMS.UI.Controls;
using SarasaviLMS.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SarasaviLMS.UI
{
    public partial class MainForm : Form
    {
        private int _userId;
        private string _username;
        private string _role;

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load; // Attach Load event
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Hide(); // Hide MainForm initially

            bool loggedIn = false;
            while (!loggedIn)
            {
                LoginForm loginForm = new LoginForm();
                var dialogResult = loginForm.ShowDialog();

                if (dialogResult == DialogResult.OK)  // Login successful
                {
                    loggedIn = true;

                    // Set State
                    _userId = SessionManager.UserId;
                    _username = SessionManager.Username;
                    _role = SessionManager.Role;

                    this.Show(); // Show MainForm
                    LoadDashboardBasedOnRole(_role);  // Load the appropriate dashboard
                }
                else if (dialogResult == DialogResult.Retry)  // User wants to register
                {
                    RegisterForm registerForm = new RegisterForm();
                    registerForm.ShowDialog();
                    // After registration, loop will restart and show the LoginForm again
                }
                else  // Login failed or user closed the login form
                {
                    Application.Exit();  // Close the application if the user doesn't log in
                    break;
                }
            }
        }

        private void LoadDashboardBasedOnRole(string role)
        {
            UserControl dashboard = null;

            switch (role)
            {
                case "Admin":
                    dashboard = new AdminDashboardControl();
                    break;
                case "User":
                    dashboard = new UserDashboardControl();
                    break;
                // Add more cases as needed
                default:
                    MessageBox.Show("Invalid role!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                    break;
            }

            if (dashboard != null)
            {
                dashboard.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(dashboard);
            }
        }

        public void ClearAndAddControl(Control newControl)
        {
            // Clear existing controls
            this.Controls.Clear();

            // Add the new control
            this.Controls.Add(newControl);
        }

    }
}
