
using System.Configuration;

namespace OnlineTicketBookingApp
{
    class BusTicketBooking
    {
        public static string adminName = ConfigurationManager.AppSettings["userName"].ToString();
        public static string adminPassword = ConfigurationManager.AppSettings["password"].ToString();

        static void Main(string[] args)
        {
            Admin admin = new Admin();
            Admin.busRespository.BusDetailsCollection();
            admin.Login();
            admin.Validate();

        }
    }
}

