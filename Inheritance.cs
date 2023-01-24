// using System;

// namespace inheritanceprac
// {
//     class user{
//         public string ?name;
//         public string ?email;
//         private string ?Location;
//         public user(){
//             System.Console.WriteLine("User details");
//         }
//         public void GetUserInfo(string loc)
//        {
//           Location = loc;
//           Console.WriteLine("Name: {0}", name);
//           Console.WriteLine("Location: {0}", Location);
//           System.Console.WriteLine("Email id :{0}",email);
//        }

//         public class Details: user
//     {
//        public int Age;
//        public string department = "";
//        public Details()
//        {
//           Console.WriteLine("Child Class Constructor");
//        }
//        public void GetAge()
//        {
//           Console.WriteLine("Age: {0}", Age);
//        }
//        public void GetDepartment()
//        {
//         System.Console.WriteLine("Department:{0}",department);
//        }
//     }

//multi level
// public class A
//     {
//        public string ?Name;
//        public void GetName()
//        {
//           Console.WriteLine("Name: {0}", Name);
//        }
//     }
//     public class B: A
//     {
//        public string ?Location;
//        public void GetLocation()
//        {
//           Console.WriteLine("Location: {0}", Location);
//        }
//     }
//     public class C: B
//     {
//        public int Age;
//        public void GetAge()
//        {
//           Console.WriteLine("Age: {0}", Age);
//        }
//     }

//     class inheritanceprac
//     {
//         public static void Main(string[] args)
//         {
//             Details d=new Details();
//             d.Age=45;
//             System.Console.WriteLine("Enter email");
//             string demail=Console.ReadLine()!;
//             d.email=demail;
//             d.department="Tech";
//             d.name="Narayan Kumar";
//             d.GetUserInfo("kolkata");
//             d.GetDepartment();
//             // System.Console.WriteLine(d.GetDepartment);
//             d.GetAge();
//             // System.Console.WriteLine(d.GetAge);
//         }
//     }

//     }
// }