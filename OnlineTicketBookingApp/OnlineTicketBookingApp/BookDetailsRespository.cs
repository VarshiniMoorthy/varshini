using System;
using System.Collections.Generic;

namespace OnlineTicketBookingApp
{
    class BookDetailsRespository
    {
        public static Dictionary<string, BookDetailsRespository> dictionaryBookDetails = new Dictionary<string, BookDetailsRespository>();

        public string Name { set; get; }
        public static int Id = 0;
        public string Source { get; set; }
        public string Destination { get; set; }
        public string Type { get; set; }
        public int NumberOfTickets { get; set; }

        BookDetailsRespository(string source ,string destination,string type,int numberOfTickets,int id)
        {
          
            Source = source;
            Destination = destination;
            Type = type;
            NumberOfTickets = numberOfTickets;
            Id = id;

        }

        internal void BookingDetails()
        {
            Console.WriteLine("enter yor name:");
            Name = Console.ReadLine();
            Console.WriteLine("enter your source location:");
            Source = Console.ReadLine();
            Console.WriteLine("enter your destination location:");
            Destination = Console.ReadLine();
            Console.WriteLine("Enter the Type of bus: AC/NON AC:");
            Type = Console.ReadLine();
            Console.WriteLine("Enter NumberOfTickets:");
            int value;
            bool result = int.TryParse(Console.ReadLine(), out value);
            if (result)
                NumberOfTickets = value;
            Id++;
            dictionaryBookDetails.Add(Name, new BookDetailsRespository( Source, Destination, Type,NumberOfTickets,Id));

        }
        internal void AddingDummyValues()
        {
            dictionaryBookDetails.Add("sumathi", new BookDetailsRespository("chennai", "coimbatore", "Ac",4, 1));
            dictionaryBookDetails.Add("malathi", new BookDetailsRespository("coimbatore", "chennai", "Non Ac", 5, 2));
            dictionaryBookDetails.Add("prathiba", new BookDetailsRespository("chennai", "coimbatore", "Ac", 4, 3));


        }
        internal void BookDetailsDisplay()
        {
            Console.WriteLine(Id+" "+Name+" "+" "+Source+" "+Destination+" "+Type+" "+NumberOfTickets );
        }
        public BookDetailsRespository()
        {

        }
    }
}
