//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exception_Handling
//{
//    internal class Class1
//    {
//        static void Main()
//        {
//            int number;
//            int n;

//            Console.WriteLine("Enter number");
//            number = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Enter 2nd number");
//            n = Convert.ToInt32(Console.ReadLine());
//            int res = 0;
//            try
//            {
//                res = number / n;
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Cannot divided by zero");
//            }
//            finally
//            {
//                Console.WriteLine("wheather exception obtain or not");
//            }

//            Console.WriteLine(res);
//            Console.WriteLine("hello world");
//        }
//    }
//}


////if try block code is not excute then catch block print .. and finally block ptint
////but try block is excute .. then catch block is not excute direct jump on finally block

