using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLMS.Models
{
    public class Copy
    {
        public int CopyId { get; set; }
        public int BookId { get; set; }  
        public int CopyNumber { get; set; }
        public bool IsReference { get; set; }
        public string Status { get; set; } 
    }
}
