using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SarasaviLMS.Utils
{
    public static class SessionManager
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }

        public static void ClearSession()
        {
            UserId = 0;
            Username = string.Empty;
            Role = string.Empty;
        }
    }
}
