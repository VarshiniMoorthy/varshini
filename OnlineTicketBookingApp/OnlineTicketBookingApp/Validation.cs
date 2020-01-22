using System;
using System.Text.RegularExpressions;

namespace OnlineTicketBookingApp
{
    class Validation
    { 
        public int IsValidEmailAddress(string email)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            if (match.Success)
                //Console.Write(email + " is correct in email format\n");
                return 1;
            else
                //Console.Write(email + " is not in email format\n");
                return 0;
        }
    }
}
