using SarasaviLMS.Data;
using SarasaviLMS.Models;
using SarasaviLMS.Utils;
using System;
using System.Collections.Generic;

namespace SarasaviLMS.Services
{
    internal class ReservationService
    {
        private readonly ReservationDAL _reservationDAL;

        public ReservationService()
        {
            _reservationDAL = new ReservationDAL();
        }

        public bool AddNewReservation(Reservation reservation, out string errorMessage)
        {
            // Validate Reservation object
            var validationResult = ValidateReservation(reservation);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Save the reservation using the DAL
            if (_reservationDAL.SaveReservation(reservation))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to save the reservation.";
                return false;
            }
        }

        public bool UpdateReservation(Reservation reservation, out string errorMessage)
        {
            // Validate Reservation object
            var validationResult = ValidateReservation(reservation);
            if (!validationResult.IsValid)
            {
                errorMessage = validationResult.ErrorMessage;
                return false;
            }

            // Update the reservation using the DAL
            if (_reservationDAL.UpdateReservation(reservation))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to update the reservation.";
                return false;
            }
        }

        public Reservation GetReservationById(int reservationId)
        {
            // Fetch reservation by ID
            return _reservationDAL.GetReservationById(reservationId);
        }

        public List<Reservation> GetReservationsByUserId(int userId)
        {
            // Fetch reservations by User ID
            return _reservationDAL.GetReservationsByUserId(userId);
        }

        public bool DeleteReservation(int reservationId, out string errorMessage)
        {
            // Delete the reservation
            if (_reservationDAL.DeleteReservation(reservationId))
            {
                errorMessage = null;
                return true;
            }
            else
            {
                errorMessage = "Failed to delete the reservation.";
                return false;
            }
        }

        private ValidationResult ValidateReservation(Reservation reservation)
        {
            if (reservation.UserId <= 0)
            {
                return new ValidationResult(false, "Invalid User ID.");
            }

            if (reservation.BookId <= 0)
            {
                return new ValidationResult(false, "Invalid Book ID.");
            }

            if (reservation.ReservationDate == default(DateTime))
            {
                return new ValidationResult(false, "Reservation Date is required.");
            }

            if (string.IsNullOrWhiteSpace(reservation.Status))
            {
                return new ValidationResult(false, "Status is required.");
            }

            return new ValidationResult(true, "Validation succeeded.");
        }
    }
}
