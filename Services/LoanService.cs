using SarasaviLMS.Data;
using SarasaviLMS.Models;
using SarasaviLMS.Utils;
using System;
using System.Collections.Generic;

namespace SarasaviLMS.Services
{
    internal class LoanService
    {
        private readonly LoanDAL _loanDAL;

        public LoanService()
        {
            _loanDAL = new LoanDAL();
        }

        public bool AddNewLoan(Loan loan, out string errorMessage)
        {
            // Validate Loan object
            var validationResult = ValidateLoan(loan);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Save the loan using the DAL
            if (_loanDAL.SaveLoan(loan))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to save the loan.";
                return false;
            }
        }

        public bool UpdateLoan(Loan loan, out string errorMessage)
        {
            // Validate Loan object
            var validationResult = ValidateLoan(loan);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Update the loan using the DAL
            if (_loanDAL.UpdateLoan(loan))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to update the loan.";
                return false;
            }
        }

        public Loan GetLoanById(int loanId)
        {
            // Fetch loan by ID
            return _loanDAL.GetLoanById(loanId);
        }

        public List<Loan> GetLoansByUserId(int userId)
        {
            // Fetch loans by User ID
            return _loanDAL.GetLoansByUserId(userId);
        }

        public bool DeleteLoan(int loanId, out string errorMessage)
        {
            // Delete the loan
            if (_loanDAL.DeleteLoan(loanId))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to delete the loan.";
                return false;
            }
        }

        private ValidationResult ValidateLoan(Loan loan)
        {
            if (loan.UserId <= 0)
            {
                return new ValidationResult(false, "Invalid User ID.");
            }

            if (loan.CopyId <= 0)
            {
                return new ValidationResult(false, "Invalid Copy ID.");
            }

            if (loan.LoanDate == default)
            {
                return new ValidationResult(false, "Loan Date is required.");
            }

            if (loan.DueDate == default)
            {
                return new ValidationResult(false, "Due Date is required.");
            }

            return new ValidationResult(true, "Validation succeeded.");
        }
    }
}
