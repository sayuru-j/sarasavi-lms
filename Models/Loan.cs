using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLMS.Models
{
    internal class Loan
    {
        public int LoanId { get; set; }
        public int UserId { get; set; }
        public int CopyId { get; set; } 
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime DueDate { get; set; }
    }
}
