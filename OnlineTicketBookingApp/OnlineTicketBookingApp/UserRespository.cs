using System;
using System.Collections.Generic;
namespace OnlineTicketBookingApp
{
    class UserRespository 
    {
        
       public static  Dictionary<string, User> dictionary = new Dictionary<string, User>();

       
       internal void UserDetails()
                {
          
            foreach (var values in dictionary)
             {

                 var val = values.Value;
                 Console.WriteLine( val.Id +" "+ values.Key+" "+ val.Age + " " + val.Password + " " + val.Gender );
         

             }
        }
        internal void UserAccessLevel()
        {
            int choice;
            int choices = 0;
            bool cancelFlag = false;
            bool choiceStatus;
            int status = 0;
            do
            {
             
                    Console.WriteLine("Enter the process to be perfomed :");
                    Console.WriteLine("1.View\n2.Booktickets\n3.PreviewDetails\n4.CancelTickets");
                    choiceStatus = int.TryParse(Console.ReadLine(), out choice);
                    if (choiceStatus)
                    {

                        switch (choice)
                        {
                            case 1:
                                
                            Admin.busRespository.ViewAvailableBusDetails();
                            break;

                            case 2:
                                Admin.bookDetailsRespository.BookingDetails();
                                BusRespository.bus.AvaliableSeats -= Admin.bookDetailsRespository.NumberOfTickets;
                                break;
                            case 3:
                                if (!cancelFlag)
                                    Admin.bookDetailsRespository.BookDetailsDisplay();
                                else
                                Console.WriteLine("Ticket cancelled");
                                break;
                            case 4:
                               BusRespository.bus.AvaliableSeats += Admin.bookDetailsRespository.NumberOfTickets;
                                Console.WriteLine("avaliable tickets:" + BusRespository.bus.AvaliableSeats);
                                cancelFlag = true;
                                break;
                        }
                     
                    }
                    else
                    {
                        Console.WriteLine("Enter the process to be perfomed :");
                        Console.WriteLine("1.View\n2.Booktickets\n3.PreviewDetails\n4.CancelTickets");
                        choiceStatus = int.TryParse(Console.ReadLine(), out choice);
                    }

                Console.WriteLine("Do you want to continuesss (1/2):\n1.Continue\n2.Exit");
                try
                {
                    choiceStatus = int.TryParse(Console.ReadLine(), out choices);
                    if (choiceStatus)
                    {
                        status = 1;
                    }
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(exception.Message);
                }
            } while (choices == 1&&status == 1);
        }
    }
}

        
    

            




