//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exception_Handling
//{

//    internal class Class16
//    {
//        static void Main()
//        {
//            int[] arr = new int[3];
//            arr[0] = 1;
//            arr[1] = 2;
//            arr[2] = 3;
            
//            try
//            {
//                for(int i = 0; i <4; i++)
//                {
//                    Console.WriteLine(arr[i]);
//                }
//            }
//            catch (IndexOutOfRangeException ex)
//            {
//                Console.WriteLine("try block wrong");
//                Console.WriteLine(ex.Message);
//            }
//            finally
//            {
//                Console.WriteLine("it is always execute");
//            }
//            Console.WriteLine("Bye");
//        }
//    }
//}

////using IndexOutOfRangeException --- when we use it it showing us our array out of rage messege