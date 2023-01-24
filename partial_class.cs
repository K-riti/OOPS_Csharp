// using System;

// namespace PartialClassDemo
// {
//     //Partial class declaration
//     partial class Employee
//     {
//          public string ?FirstName { get; set; } 
//          public string ?Designation { get; set; }      
//     }


//     //Partial class declaration   
//     partial class Employee
//     {
//         public string ?LastName { get; set; }
//         public decimal Salary { get; set; }
//     }
// class Program
//     {
//         static void Main(string[] args)
//         {
//             Employee emp = new Employee();
//             emp.FirstName = "Jimih";
//             emp.LastName = "Shithm";
//             emp.Designation = "VP - Products";
//             emp.Salary = 10000.0m;
 
//             Console.WriteLine("Name        : {0} {1}", emp.FirstName, emp.LastName );
//             Console.WriteLine("Designation : {0}", emp.Designation);
//             Console.WriteLine("Salary      : {0}", emp.Salary);
//             Console.ReadLine();
//         }
//     }
// }