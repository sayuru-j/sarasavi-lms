using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLMS.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string NIC { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    }
}
