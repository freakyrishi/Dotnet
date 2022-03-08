//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    class program
//    {
//        public void data1()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Number = " + i);
//                Thread.Sleep(1000);
//            }
//        }
//        public void data2()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Number = " + i);
//                Thread.Sleep(1000);
//            }
//        }
//        public void data3()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("Number = " + i);
//                Thread.Sleep(1000);
//            }
//        }
//    }
//    internal class Class25
//    {
//        static void Main()
//        {
//            program p = new program();
//            ThreadStart ts1 = new ThreadStart(p.data1);
//            ThreadStart ts2 = new ThreadStart(p.data2);
//            ThreadStart ts3 = new ThreadStart(p.data3);
//            Thread t1 = new Thread(ts1);
//            t1.Start();

//            Thread t2 = new Thread(ts2);
//            t2.Start();

//            Thread t3 = new Thread(ts3);
//            t3.Start();
//        }
//    }
//}

////simultaneously run hoga...all th three functions.