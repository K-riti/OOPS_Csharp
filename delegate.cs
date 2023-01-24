// using System;
// namespace delegaterd
// {
//     public delegate void DGetArea(double length, double breadth);
//     public delegate string DGreetings(string name);

//     class delegatef
//     {
//         public void GetArea(double length, double breadth)
//         {
//             System.Console.WriteLine("Area is: " + length * breadth);
//         }
//         public void GetPerimeter(double length, double breadth)
//         {
//             System.Console.WriteLine("Perimeter is:" + 2 * (length + breadth));
//         }
//         public static string Wish(string name)
//         {
//             return "Good Morning " + name;
//         }


//         static void Main()
//         {
//             delegatef p = new delegatef();
//             p.GetArea(30, 40);
//             DGetArea d1 = new DGetArea(p.GetArea);

//             // MultiCast Delegate 
//             DGetArea d2 = p.GetArea;
//             d2 += p.GetPerimeter;
//             d1(83, 121);
//             d1.Invoke(50, 83);
//             d2(69, 72);

//             DGreetings dg1 = new DGreetings(Wish);
//             string msg = dg1.Invoke("Levat");
//             System.Console.WriteLine(msg);

//             //Anoymous delegate
//             DGreetings dg2 = delegate (string name)
//              { 
//                 return "Good afternoon " + name;
//                  };
//             string str2 = dg2.Invoke("Hope");
//             System.Console.WriteLine(str2);

//             //Lamda expression

//             DGreetings dg3 =(name) =>
//             {
//                 return "Good Evening " + name;
//             };
//             string str3 = dg3.Invoke("Suga");
//             System.Console.WriteLine(str3);
//         }
//     }

// }