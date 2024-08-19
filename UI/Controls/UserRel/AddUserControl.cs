using SarasaviLMS.Models;
using SarasaviLMS.Services;
using SarasaviLMS.Utils;
using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SarasaviLMS.UI.Controls
{
    public partial class AddUserControl : UserControl
    {
        public event Action<User> UserAdded;
        public event Action<User> UserUpdated;

        private UserService _userService;
        private User _currentUser;

        public AddUserControl(User user = null)
        {
            InitializeComponent();
            _userService = new UserService();

            if (user != null)
            {
                _currentUser = user;
                PopulateFieldsForUpdate();
            }
        }

        private void PopulateFieldsForUpdate()
        {
            txtName.Text = _currentUser.Name;
            txtNIC.Text = _currentUser.NIC;
            txtSex.Text = _currentUser.Sex;
            txtAddress.Text = _currentUser.Address;
            txtRole.Text = _currentUser.Role;
            btnSave.Text = "Update User";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtNIC.Text) ||
                string.IsNullOrWhiteSpace(txtSex.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text) ||
                string.IsNullOrWhiteSpace(txtRole.Text))
            {
                MessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_currentUser == null)
            {
                var newUser = new User
                {
                    Name = txtName.Text.Trim(),
                    NIC = txtNIC.Text.Trim(),
                    Sex = txtSex.Text.Trim(),
                    Address = txtAddress.Text.Trim(),
                    Role = txtRole.Text.Trim()
                };

                if (_userService.AddNewUser(newUser, out string errMsg))
                {
                    UserAdded?.Invoke(newUser);
                    ReturnToUserManagementControl();
                }
                else
                {
                    MessageBox.Show($"Failed to add user: {errMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                _currentUser.Name = txtName.Text.Trim();
                _currentUser.NIC = txtNIC.Text.Trim();
                _currentUser.Sex = txtSex.Text.Trim();
                _currentUser.Address = txtAddress.Text.Trim();
                _currentUser.Role = txtRole.Text.Trim();

                if (_userService.UpdateUser(_currentUser, out string errMsg))
                {
                    UserUpdated?.Invoke(_currentUser);
                    ReturnToUserManagementControl();
                }
                else
                {
                    MessageBox.Show($"Failed to update user: {errMsg}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnToUserManagementControl()
        {
            var parentForm = this.Parent as Form;
            if (parentForm != null)
            {
                var userManagementControl = new UserManagementControl();
                userManagementControl.Dock = DockStyle.Fill;

                this.Parent.Controls.Remove(this);
                parentForm.Controls.Add(userManagementControl);
                userManagementControl.BringToFront();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Navigator.Navigate(ParentForm, NavigationTarget.UserManagement);
        }
    }
}
