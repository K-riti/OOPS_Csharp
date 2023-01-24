//  using System;
//  namespace Poly
//  {
// public class Interest
// {
//     //         // interest for 1 year of tenure
//     public virtual double Interestfor1yr(double amount, double rate)
//     {
//         return amount + (amount * rate);
//     }
// }
//     //         public double Interestfor1yr(double amount, double rate, string holdertype)
//     //         {
//     //             return amount + (amount * rate) + 2000;
//     //         }
//     public class SimpleInterest : Interest
//     {
//         public override double Interestfor1yr(double amount, double rate)
//         {
//             return amount + (amount * rate) + 1000;
//         }
//     }
//     // second child class
//     public class FixedInterest : Interest
//     {
//         public override double Interestfor1yr(double amount, double rate)
//         {
//             return amount + (amount * rate) + 1500;
//         }
//     }
//     public class Program
//     {
//                  public static void Main(string[] args)
//                 {
//                      Interest i = new Interest();

//                      double finalamount = i.Interestfor1yr(5000.00, 0.1);
//                      Console.WriteLine("Normal interest for a holder " + finalamount);

//         //             finalamount = i.Interestfor1yr(5000.00, 0.1, "prime");
//         //             Console.WriteLine("Prime interest for a holder " + finalamount);

//          //Interest i = new Interest();
//         i = new SimpleInterest();
//         finalamount = i.Interestfor1yr(5000.00,0.1);
//             Console.WriteLine("Simple interest for a holder "+finalamount);
            
//             i = new FixedInterest();
//         finalamount = i.Interestfor1yr(5000.00,0.1);
//             Console.WriteLine("Fixed interest for a holder "+finalamount);
//          }
//      }
//  }