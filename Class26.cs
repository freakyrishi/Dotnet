//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    class program
//    {
//        public void data()
//        {
//            for (int i = 0; i < 25; i++)
//            {
//                Console.WriteLine("Number = " + i);
//            }
//        }
//    }
//    internal class Class25
//    {
//        static void Main()
//        {
//            program p = new program();
//            ThreadStart ts = new ThreadStart(p.data);
//            Thread t1 = new Thread(ts);
//            t1.Start();

//            Thread t2 = new Thread(ts);
//            t2.Start();

//            Thread t3 = new Thread(ts);
//            t3.Start();
//        }
//    }
//}
