using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLMS.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public int UserId { get; set; }  
        public int BookId { get; set; }  
        public DateTime ReservationDate { get; set; }
        public string Status { get; set; }  // Status can be 'Pending', 'Fulfilled', 'Cancelled'
    }
}
