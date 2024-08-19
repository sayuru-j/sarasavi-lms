using SarasaviLMS.Data;
using SarasaviLMS.Models;
using SarasaviLMS.Utils;
using System.Collections.Generic;

namespace SarasaviLMS.Services
{
    internal class InquiryService
    {
        private readonly InquiryDAL _inquiryDAL;

        public InquiryService()
        {
            _inquiryDAL = new InquiryDAL();
        }

        public bool AddNewInquiry(Inquiry inquiry, out string errorMessage)
        {
            // Validate Inquiry object
            var validationResult = ValidateInquiry(inquiry);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Save the inquiry using the DAL
            if (_inquiryDAL.SaveInquiry(inquiry))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to save the inquiry.";
                return false;
            }
        }

        public bool UpdateInquiry(Inquiry inquiry, out string errorMessage)
        {
            // Validate Inquiry object
            var validationResult = ValidateInquiry(inquiry);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Update the inquiry using the DAL
            if (_inquiryDAL.UpdateInquiry(inquiry))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to update the inquiry.";
                return false;
            }
        }

        public Inquiry GetInquiryById(int inquiryId)
        {
            // Fetch inquiry by ID
            return _inquiryDAL.GetInquiryById(inquiryId);
        }

        public List<Inquiry> GetInquiriesByUserId(int userId)
        {
            // Fetch inquiries by User ID
            return _inquiryDAL.GetInquiriesByUserId(userId);
        }

        public List<Inquiry> GetAllInquiries()
        {
            // Fetch all inquiries
            return _inquiryDAL.GetAllInquiries();
        }

        public bool DeleteInquiry(int inquiryId, out string errorMessage)
        {
            // Delete the inquiry
            if (_inquiryDAL.DeleteInquiry(inquiryId))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to delete the inquiry.";
                return false;
            }
        }

        private ValidationResult ValidateInquiry(Inquiry inquiry)
        {
            if (inquiry.UserId <= 0)
            {
                return new ValidationResult(false, "Invalid User ID.");
            }

            if (inquiry.BookId <= 0)
            {
                return new ValidationResult(false, "Invalid Book ID.");
            }

            if (inquiry.InquiryDate == default)
            {
                return new ValidationResult(false, "Inquiry Date is required.");
            }

            if (string.IsNullOrWhiteSpace(inquiry.InquiryDetails))
            {
                return new ValidationResult(false, "Inquiry Details are required.");
            }

            return new ValidationResult(true, "Validation succeeded.");
        }
    }
}
