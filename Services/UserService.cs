using SarasaviLMS.Data;
using SarasaviLMS.Models;
using SarasaviLMS.Utils;
using System.Text.RegularExpressions;

namespace SarasaviLMS.Services
{
    internal class UserService
    {
        private UserDAL _user;

        public UserService() { 
            UserDAL user = new UserDAL();
            _user = user;
        }

        public ValidationResult ValidateUser(User user)
        {
            if (string.IsNullOrWhiteSpace(user.Username))
            {
                return new ValidationResult(false, "Username is required.");
            }

            if (!IsValidEmail(user.Email))
            {
                return new ValidationResult(false, "Invalid email format.");
            }

            if (string.IsNullOrWhiteSpace(user.Password) || user.Password.Length < 6)
            {
                return new ValidationResult(false, "Password must be at least 6 characters long.");
            }

            return new ValidationResult(true, "Validation succeeded.");
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

            // Hash the password
            string hashedPassword = PasswordHelper.HashPassword(user.Password);

            if (hashedPassword == null)
            {
                errorMessage = "Failed to hash the password.";
                return false;
            }

            user.Password = hashedPassword; // Replace plain password with the hashed password

            // Save the user using the DAL
            if (_user.SaveUser(user))
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

        public User AuthenticateUser(string username, string password)
        {
            // Fetch user by username
            var user = _user.GetUserByUsername(username);
            if (user == null)
            {
                return null; // User not found
            }

            // Verify the password
            if (PasswordHelper.VerifyPassword(password, user.Password))
            {
                return user; // Authentication successful
            }
            else
            {
                return null; // Password does not match
            }
        }

        private bool IsValidEmail(string email)
        {
            // Simple email validation using regex
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }
    }
}
