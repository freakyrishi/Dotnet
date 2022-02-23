/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class program
    {
        int rno;
        string name;
        int cost;

        public program()
        {
            rno = 10;
            name = "Rohit";
            cost = 50000;
        }

        public void showdata()
        {
            Console.WriteLine("RollNo-" + rno);
            Console.WriteLine("Name-"+name);
            Console.WriteLine("Cost-"+cost);
        }
    }

    class program1 : program
    {
        int price;
        string value;

        public program1(int price, string value)
        {
            this.price = price;
            this.value = value;
        }
        public void getdata()
        {
            price = 96;
            value = "Important Product";
        }

        public void showall()
        {
            Console.WriteLine("price-" + price);
            Console.WriteLine("value-" + value);
        }
    }
    internal class Class2
    {
        static void Main()
        {
                program1 p2 = new program1(89,"Remote");
            p2.showdata();  
                p2.showall();  
            Console.ReadLine();
        }

    }
}
*/