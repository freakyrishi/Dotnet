/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class account
    {
        int id;
        string name;
        public static float roi = 8.8f;

        public void getdata(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public void showdatat()
        {
            Console.WriteLine("Id ="+id);
            Console.WriteLine("Name ="+name);
            Console.WriteLine("Roi ="+roi);
        }
    }
    internal class Class1
    {
        static void Main()
        {
            account.roi = 9.4f;
            account a=new account();
            account b=new account();
            a.getdata(22,"Rohit");
            b.getdata(2222, "Roshan");

            a.showdatat();
            b.showdatat();
        }
    }
}
*/