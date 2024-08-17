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
                    this.Show(); // Show MainForm
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
    }
}
