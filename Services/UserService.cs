using SarasaviLMS.Data;
using SarasaviLMS.Models;
using SarasaviLMS.Utils;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SarasaviLMS.Services
{
    internal class UserService
    {
        private readonly UserDAL _userDAL;

        public UserService()
        {
            _userDAL = new UserDAL();
        }

        public bool AddNewUser(User user, out string errorMessage)
        {
            // Validate User object
            var validationResult = ValidateUser(user);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Save the user using the DAL
            if (_userDAL.SaveUser(user))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to save the user.";
                return false;
            }
        }

        public bool UpdateUser(User user, out string errorMessage)
        {
            // Validate User object
            var validationResult = ValidateUser(user);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Update the user using the DAL
            if (_userDAL.UpdateUser(user))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to update the user.";
                return false;
            }
        }

        public bool DeleteUser(int userId, out string errorMessage)
        {
            // Delete the user using the DAL
            if (_userDAL.DeleteUser(userId))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to delete the user.";
                return false;
            }
        }

        public User GetUserByNIC(string nic)
        {
            // Fetch user by NIC
            return _userDAL.GetUserByNIC(nic);
        }

        public List<User> GetAllUsers()
        {
            // Fetch all users
            return _userDAL.GetAllUsers();
        }

        public bool IsNICUnique(string nic)
        {
            // Check if the NIC is unique
            return _userDAL.IsNICUnique(nic);
        }

        private ValidationResult ValidateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Name))
            {
                return new ValidationResult(false, "Name is required.");
            }

            if (string.IsNullOrWhiteSpace(user.NIC))
            {
                return new ValidationResult(false, "NIC is required.");
            }

            if (!IsValidNIC(user.NIC))
            {
                return new ValidationResult(false, "Invalid NIC format.");
            }

            if (string.IsNullOrWhiteSpace(user.Sex) || !(user.Sex == "M" || user.Sex == "F"))
            {
                return new ValidationResult(false, "Valid Sex (M or F) is required.");
            }

            if (string.IsNullOrWhiteSpace(user.Address))
            {
                return new ValidationResult(false, "Address is required.");
            }

            if (string.IsNullOrWhiteSpace(user.Role))
            {
                return new ValidationResult(false, "Role is required.");
            }

            if (!IsNICUnique(user.NIC))
            {
                return new ValidationResult(false, "NIC already exists.");
            }

            return new ValidationResult(true, "Validation succeeded.");
        }

        private bool IsValidNIC(string nic)
        {
            // Regex pattern for old NIC format: 9 digits followed by 'V' or 'v'
            string oldNicPattern = @"^\d{9}[Vv]$";

            // Regex pattern for new NIC format: 12 digits only
            string newNicPattern = @"^\d{12}$";

            // Check if NIC matches either the old or new format
            return Regex.IsMatch(nic, oldNicPattern) || Regex.IsMatch(nic, newNicPattern);
        }
    }
}
