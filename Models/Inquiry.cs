using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLMS.Models
{
    public class Inquiry
    {
        public int InquiryId { get; set; }
        public int UserId { get; set; } 
        public int BookId { get; set; }  
        public DateTime InquiryDate { get; set; }
        public string InquiryDetails { get; set; }
    }
}
