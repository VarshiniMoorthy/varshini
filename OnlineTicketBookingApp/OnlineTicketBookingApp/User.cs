using System;
namespace OnlineTicketBookingApp
{
    class User
    {
        public string UserName { set; get; }
        public byte Age { set; get; }
        public string Gender { set; get; }
        public string Password { set; get; }
        public int Id;
        public string Source { get; set; }
        public string Destination { get; set; }
        
        //Parameterized Constructor

        //default access modifier is private 

        internal User( byte age, string gender, string password,int id)
        {
          
            Age = age;
            Gender = gender;
            Password = password;
           
            Id = id;
        }

        //default access modifier is private 

        internal User()
        {
          
        }
    }
}