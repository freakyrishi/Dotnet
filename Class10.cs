//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Delegate
//{
//    delegate int del1(int x,int y);
//    internal class Class10
//    {
//        public int sub(int x,int y)
//        {
//            return x - y;
//        }

//        public static void Main()
//        {
//            Class10 c10 = new Class10();
//            del1 d1 = new del1(c10.sub);
//            int res=d1(10,6);
//            Console.WriteLine(res);
//        }
//    }
//}
