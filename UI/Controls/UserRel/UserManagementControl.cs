using SarasaviLMS.Models;
using SarasaviLMS.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SarasaviLMS.UI.Controls
{
    public partial class UserManagementControl : UserControl
    {
        private UserService _userService;
        private List<User> _users;

        public UserManagementControl()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private void UserManagementControl_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            _users = _userService.GetAllUsers();
            dgvUsers.DataSource = _users;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            var addUserControl = new AddUserControl();
            addUserControl.UserAdded += (newUser) =>
            {
                _users.Add(newUser);
                LoadUsers();
            };

            this.Parent.Controls.Add(addUserControl);
            addUserControl.Dock = DockStyle.Fill;
            this.Visible = false;
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var selectedUser = dgvUsers.SelectedRows[0].DataBoundItem as User;
                var editUserControl = new AddUserControl(selectedUser);
                editUserControl.UserUpdated += (updatedUser) =>
                {
                    var index = _users.FindIndex(u => u.UserId == updatedUser.UserId);
                    if (index >= 0)
                    {
                        _users[index] = updatedUser;
                        LoadUsers();
                    }
                };

                this.Parent.Controls.Add(editUserControl);
                editUserControl.Dock = DockStyle.Fill;
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Please select a user to edit.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                var selectedUser = dgvUsers.SelectedRows[0].DataBoundItem as User;
                var result = MessageBox.Show($"Are you sure you want to delete user {selectedUser.Name}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (_userService.DeleteUser(selectedUser.UserId, out string errorMessage))
                    {
                        _users.Remove(selectedUser);
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete user: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "No User Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
