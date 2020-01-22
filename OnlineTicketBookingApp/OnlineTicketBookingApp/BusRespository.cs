using System;
using System.Collections.Generic;

namespace OnlineTicketBookingApp
{
    class BusRespository
    {
        public static Dictionary<int, Bus> busDictionary = new Dictionary<int, Bus>();
        public int Id;
        internal static Bus bus = new Bus();
        bool status;
    
        internal void BusDetailsCollection()
        {
            busDictionary.Add(1, new Bus("AirOne", "Cbe", "Chennai","Ac", 1000, 50));
            //busDictionary.Add(2, new Bus("KPR travels", "Chennai", "cbe","NonAc", 1200, 40));
            //busDictionary.Add(3, new Bus("SPS", "Cbe", "Chennai","Ac", 600, 50));
            
        }
       
        internal void AddBusDetails()
        {
            try
            {
                Console.Write("Enter Bus Name : ");
                bus.BusName = Console.ReadLine();
                //string name = passenger.PassengerName;
                Console.Write("Enter StartLocation : ");
                bus.StartingLocation = Console.ReadLine();
                

                Console.Write("Enter TargetLocation : ");
                bus.DestinationLocation = Console.ReadLine();
                

                Console.Write("Enter Total Available Ticket : ");
                status = byte.TryParse(Console.ReadLine(), out byte availableSeats);
                if (status)
                    bus.AvaliableSeats = availableSeats;

                Console.Write("Enter the Price per Ticket : ");
                status = float.TryParse(Console.ReadLine(), out float price);
                if (status)
                    bus.Price = price;

                Id = busDictionary.Count;
                
                ++Id;
                busDictionary.Add(Id, new Bus(bus.BusName, bus.StartingLocation, bus.DestinationLocation,bus.TypeOfBus, bus.Price,bus.AvaliableSeats));
            }
            catch (FormatException exception)
            {
                Console.WriteLine("Please enter valid Format", exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }

        internal void ViewAvailableBusDetails()
        {
            try
            {
                Console.WriteLine("Welcome to bus Ticket Booking\n");
                foreach (KeyValuePair<int, Bus> values in busDictionary)
                {
                    Console.WriteLine("BusName:" + values.Value.BusName);
                    Console.WriteLine("Source Location:" + values.Value.StartingLocation);
                    Console.WriteLine("Destination Location:" + values.Value.DestinationLocation);
                    Console.WriteLine("Cost for one ticket:" + values.Value.Price);
                    Console.WriteLine("Tickets:" + values.Value.AvaliableSeats);
                }
                    
            }
            catch (NullReferenceException exception)
            {
                Console.WriteLine("Something went wrong", exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine("Something went wrong", exception.Message);
            }
        }
        internal void RemoveBusDetails()
        {
            try
            {
                Console.Write("Enter the bus id you want to remove : ");
                status = int.TryParse(Console.ReadLine(), out int index);
                if (status)
                {
                    busDictionary.Remove(index);
                }
                else
                    Console.WriteLine("Please enter valid index!!");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Something went wrong", exception.Message);
            }
        }
    }
}




