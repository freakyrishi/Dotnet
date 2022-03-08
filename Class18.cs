//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exception_Handling
//{
//    internal class Class18
//    {
//       static void Main()
//        {
//            int[] arr = new int[3];
//            arr[0] = 1;
//            arr[1] = 2;
//            arr[2] = 3;

//            try
//            {
//                for (int i = 0; i <=3; i++)
//                {
//                    Console.WriteLine(arr[i]);
//                }
//            }
//            catch (IndexOutOfRangeException ex)       //Index was outside the bounds of the array.
//            {
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("finally means execute all");
//            }

//        }
//    }
//}
