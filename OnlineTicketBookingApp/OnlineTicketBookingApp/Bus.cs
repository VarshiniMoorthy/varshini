using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTicketBookingApp
{
    class Bus
    {
        public string BusName { get; set; }
        public string StartingLocation { get; set; }
        public string DestinationLocation { get; set; }
        public string TypeOfBus { get; set; }
        public float Price { get; set; }
        public int AvaliableSeats { get; set; }
        public int Id { get; set; }

       internal Bus(string busName, string startingLocation, string destinationLocation, string typeOfBus,float price, int avalibleSeats)
        {
            BusName = busName;
            StartingLocation = startingLocation;
            DestinationLocation = destinationLocation;
            TypeOfBus = typeOfBus;
            Price = price;
            AvaliableSeats = avalibleSeats;
          
        }
        internal Bus()
        {

        }
    }
}
