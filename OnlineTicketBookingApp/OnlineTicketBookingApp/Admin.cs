using System;
namespace OnlineTicketBookingApp
{
    class Admin 
    {
        public string UserName { get; set; }
        public string NewPassword { get; set; }
        public string Role { get; set; }
        Validation validation = new Validation();
        User user = new User();
        internal static BookDetailsRespository bookDetailsRespository = new BookDetailsRespository();
        UserRespository userRespository = new UserRespository();
       internal static BusRespository busRespository = new BusRespository();
       
        //BusTicketBooking busTicketBooking = new BusTicketBooking();
        internal void BusCollection()
        {
            UserRespository.dictionary.Add("sumathi@gmail.com", new User(23, "female", "snowwhite", 1));
            UserRespository.dictionary.Add("malathi@gmail.com", new User(43, "female", "correcting", 2));
        }
        internal void Removing()
        {
            //dictionary.Clear();
            Console.WriteLine("Enter the Userdetails which is to be removed:");
            UserRespository.dictionary.Remove(Console.ReadLine());
        }

        internal void SignUp()
        {
            try
            {

                /* Console.WriteLine("enter yor name:");
                 busPassenger.UserName = Console.ReadLine();*/
                do
                {
                    Console.WriteLine("Enter your UserEmailId:");
                    user.UserName = Console.ReadLine();
                    validation.IsValidEmailAddress(UserName);
                } while (validation.IsValidEmailAddress(UserName) != 1);
                validation.IsValidEmailAddress(UserName);
                Console.WriteLine("Enter your age:");
                user.Age = byte.Parse(Console.ReadLine());

                Console.WriteLine("enter your gender:");
                user.Gender = Console.ReadLine();
                Console.WriteLine("enter your password to be set:");
                user.Password = ReadPassword();

                //User.Id = User.Id++;
                //ViewSeats.AvaliableSeats--;
            }
            catch (FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }



            // Console.WriteLine(BusPassenger.Id);
            UserRespository.dictionary.Add(user.UserName, new User(user.Age, user.Gender, user.Password, user.Id++));
            Console.WriteLine("Do you want to continues to login :(1/2)\n1.Continue\n2.exit");
            int choice;
            bool status = int.TryParse(Console.ReadLine(), out choice);
            if (status)
            {
                if (choice == 1)
                    //Login();
                    userRespository.UserAccessLevel();
                else
                    Console.WriteLine("Exit");

            }
            else
                status = int.TryParse(Console.ReadLine(), out choice);
        }
        /*Console.WriteLine("UserId:");*/

        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {
                        // remove one character from the list of password characters
                        password = password.Substring(0, password.Length - 1);
                        // get the location of the cursor
                        int pos = Console.CursorLeft;
                        // move the cursor to the left by one character
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                        // replace it with space
                        Console.Write(" ");
                        // move the cursor to the left by one character again
                        Console.SetCursorPosition(pos - 1, Console.CursorTop);
                    }
                }
                info = Console.ReadKey(true);
            }

            // add a new line because user pressed enter at the end of their password
            Console.WriteLine();
            return password;
        }

        public void Login()
        {
            try
            {
                BusCollection();

                Console.WriteLine("LOGIN DETAILS");
              
                do
                {
                    Console.WriteLine("Enter your UserEmailId:");
                    UserName = Console.ReadLine();
                    validation.IsValidEmailAddress(UserName);
                } while (validation.IsValidEmailAddress(UserName) != 1);

                Console.WriteLine("Enter your password:");
                NewPassword = ReadPassword();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

        }

        //Class1 class1 = new Class1();
        internal void Validate()
        {
            if (UserName == BusTicketBooking.adminName && NewPassword == BusTicketBooking.adminPassword)
            {
                validation.IsValidEmailAddress(UserName);
                Role = RoleType.Admin.ToString();
                Console.WriteLine("your role is admin");
                Console.WriteLine("welcome Admin!!");
                Console.WriteLine("Do you want to continues:(1/2)\n1.Continue\n2.exit");
                int choice;
                //int cho = int.Parse(Console.ReadLine());
              // AdminAccessLevel();
                 bool status = int.TryParse(Console.ReadLine(), out choice);
                 if (status)
                 {
                     if (choice == 1)
                         AdminAccessLevel();
                     else
                         Console.WriteLine("Exit");

                 }
                 else
                     status = int.TryParse(Console.ReadLine(), out choice);


            }
            else
            {
                Role = RoleType.User.ToString();
                Console.WriteLine(Role);
                Console.WriteLine("your role is user");
                bool flag = true;
                // Console.WriteLine(User.Id);
                foreach (var items in UserRespository.dictionary)
                {
                    Console.WriteLine(UserRespository.dictionary.Count);
                    if (items.Key == UserName && items.Value.Password == NewPassword)
                    {
                        //Console.WriteLine(collection.dictionary[BusPassenger.Id]);
                        Console.WriteLine(items.Key + " " + items.Value.Password);
                        Console.WriteLine("existing user");
                        Console.WriteLine("book tickets");
                        flag = false;
                        Console.WriteLine("Do you want to continues:(1/2)\n1.Continue\n2.exit");
                        int choice;
                        bool status = int.TryParse(Console.ReadLine(), out choice);
                        if (status)
                        {
                            if (choice == 1)
                                userRespository.UserAccessLevel();
                            else
                                Console.WriteLine("Exit");

                        }
                        else
                            status = int.TryParse(Console.ReadLine(), out choice);
                        //flag = false;
                        //bookDetails.BookingDetails();
                    }
                }

                foreach (var item in UserRespository.dictionary)
                {
                    if (item.Key != UserName && item.Value.Password != NewPassword)
                    {
                        if (flag)
                        {
                            Console.WriteLine("new user");
                            SignUp();
                            Console.WriteLine("added sucessfully");
                            break;
                        }

                    }


                }
            }
        }
        internal void AdminAccessLevel()
        {
            //if (Role == "Admin")
            //{
                int choices = 0;
                bool cancelFlag = false;
                bool choiceStatus;
                int status = 0;
               
            // Collections collections = new Collections();
            do { 
                Console.WriteLine("Enter the process to be perfomed :");
                Console.WriteLine("1.AddBusDetails\n2.ViewAvailableBusDetails\n3.RemoveBusDetails\n4.ticketBooking\n5.CancelTicket\n6.PreviewDetails\n7.CustomerDatabase");
                int choose;
            
                choiceStatus = int.TryParse(Console.ReadLine(), out choose);
                
                
                    if (choiceStatus)
                    {
                        switch (choose)
                        {
                        case 1:
                            busRespository.AddBusDetails();
                            break;
                        case 2:
                            busRespository.ViewAvailableBusDetails();
                            break;
                        case 3:
                            busRespository.RemoveBusDetails();
                            break;
                        case 4:
                                bookDetailsRespository.BookingDetails();
                                BusRespository.bus.AvaliableSeats -= bookDetailsRespository.NumberOfTickets;
                                break;
                        case 5:
                                //bookDetails.BookingDetails();
                                BusRespository.bus.AvaliableSeats += bookDetailsRespository.NumberOfTickets;
                                cancelFlag = true;
                                break;
                        case 6:
                                if (!cancelFlag)
                                    bookDetailsRespository.BookDetailsDisplay();
                                break;
                      
                        case 7:
                                userRespository.UserDetails();
                                break;
                            
                             
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter the process to be perfomed :");
                        Console.WriteLine("1.View\n2.ticketBooking\n3.CancelTicket\n4.PreviewDetails\n5.RemoveCustomer\n6.AddingCustomer\n7.CustomerDatabase");
                        choiceStatus = int.TryParse(Console.ReadLine(), out choose);
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
                } while (status == 1 && choices == 1);


            }
        }
    }

    

