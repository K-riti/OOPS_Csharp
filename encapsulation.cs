// using System;

// using System.Text;
// namespace encap
// {
//     class User
//     {
//        private string ?location;
//        private string ?name;

//        private string ?email;

//        private int age;
//        public string ?Location
//        {
//           get
//           {
//              return location;
//           }
//           set
//           {
//              location = value;
//           }
//        }
//        public string ?Name
//        {
//          get
//          {
//              return name;
//          }
//          set
//          {
//             name = value;
//          }
//        }
//        public string ?Email
//        {
//           get
//           {
//              return email;
//           }
//           set
//           {
//              email= value;
//           }
//        }
//        public int Age
//        {
//           get
//           {
//              return age;
//           }
//           set
//           {
//              age = value;
//           }
//        }
//     }
//     class Program
//     {
//        static void Main(string[] args)
//        {
//           User u = new User();
//           // set accessor will invoke
//           u.Name = "Suresh ";
//           // set accessor will invoke
//           u.Location = "Hyderabad";
//           u.Email="shades@gmail.com";
//           u.Age=45;
//           // get accessor will invoke
//           Console.WriteLine("Name: " + u.Name);
//           // get accessor will invoke
//           Console.WriteLine("Location: " + u.Location);
//           System.Console.WriteLine(u.Age);
//           System.Console.WriteLine(u.Email);
//           //Console.WriteLine("\nPress Enter Key to Exit..");
//           //Console.ReadLine();
//        }
//     }
// }