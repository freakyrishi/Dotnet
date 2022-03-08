//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp2
//{
//    internal class Class29
//    {
//        public static void data()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                Console.WriteLine("number = "+i);
//                Thread.Sleep(100);
//            }
//        }
//        public static void Main()
//        {
//            ThreadStart ts = new ThreadStart(data);
//            Thread t1 = new Thread(ts);
//            Thread t2 = new Thread(ts);

//            t1.Start();
//            t1.Join();     // join use karne se t1 pura execute hone ke baad t2 ececute hoga
//            t2.Start();
//        }
//    }
//}