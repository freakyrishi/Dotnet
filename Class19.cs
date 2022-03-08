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
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine(ex.Message);   // showing messege-- Attempted to divide by zero.
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("Error");
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



