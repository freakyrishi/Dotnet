//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Exception_Handling
//{
//    internal class Class20
//    {
//        static void Main()
//        {
//            int age = 0;


//            try
//            {
//                Console.WriteLine("enter age");
//                age = Convert.ToInt32(Console.ReadLine());

//                if (age > 18)
//                {
//                    throw new Exception("Age is greater than 18");
//                }
//            }

//            catch (OverflowException ex)
//            {
//                Console.WriteLine("enter age");
//                age = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("perfect age");
//                Console.WriteLine(ex.Message);

//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine("enter age");
//                age = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("perfect age");
//                Console.WriteLine(ex.Message);

//            }
//            finally
//            {
//                Console.WriteLine(age);
//            }
//        }
//    }
//}


//// if we put 17 .program needed above 18 age. then try block skipped and program 17 code excute..
//// if we put 19 then will asking another ange criteria.. and then put 17 . we get perfet agd 
