using SarasaviLMS.Data;
using SarasaviLMS.Models;
using SarasaviLMS.Utils;
using System.Collections.Generic;

namespace SarasaviLMS.Services
{
    internal class CopyService
    {
        private readonly CopyDAL _copyDAL;

        public CopyService()
        {
            _copyDAL = new CopyDAL();
        }

        public bool AddNewCopy(Copy copy, out string errorMessage)
        {
            // Validate Copy object
            var validationResult = ValidateCopy(copy);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Save the copy using the DAL
            if (_copyDAL.SaveCopy(copy))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to save the copy.";
                return false;
            }
        }

        public List<Copy> GetAvailableCopiesByBookId(int bookId)
        {
            return _copyDAL.GetAvailableCopiesByBookId(bookId);
        }


        public int GetNextCopyNumber(int bookId)
        {
            // Fetch the current maximum CopyNumber for this book and add 1
            int currentMaxCopyNumber = _copyDAL.GetMaxCopyNumberForBook(bookId);
            return currentMaxCopyNumber + 1;
        }

        public bool UpdateCopy(Copy copy, out string errorMessage)
        {
            // Validate Copy object
            var validationResult = ValidateCopy(copy);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Update the copy using the DAL
            if (_copyDAL.UpdateCopy(copy))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to update the copy.";
                return false;
            }
        }

        public Copy GetCopyById(int copyId)
        {
            // Fetch copy by ID
            return _copyDAL.GetCopyById(copyId);
        }

        public List<Copy> GetCopiesByBookId(int bookId)
        {
            // Fetch copies by Book ID
            return _copyDAL.GetCopiesByBookId(bookId);
        }

        public bool DeleteCopy(int copyId, out string errorMessage)
        {
            // Delete the copy
            if (_copyDAL.DeleteCopy(copyId))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to delete the copy.";
                return false;
            }
        }

        private ValidationResult ValidateCopy(Copy copy)
        {
            if (copy.BookId <= 0)
            {
                return new ValidationResult(false, "Invalid Book ID.");
            }

            if (copy.CopyNumber <= 0)
            {
                return new ValidationResult(false, "Invalid Copy Number.");
            }

            if (string.IsNullOrWhiteSpace(copy.Status))
            {
                return new ValidationResult(false, "Status is required.");
            }

            return new ValidationResult(true, "Validation succeeded.");
        }
    }
}
