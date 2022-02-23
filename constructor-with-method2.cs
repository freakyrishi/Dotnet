/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class bike
    {
        int id;
        int price;
        string name;
        string model; 

        public bike()
        {
            id = 10;
            price = 80000;
            name = "honda";
            model = "shine";

        }
        public bike(int id,int price,string name,string model)
        {
            this.id = id;
            this.price = price;
            this.name = name;
            this.model = model;

        }
        public void getdata()
        {
            Console.WriteLine(id);
            Console.WriteLine(price);
            Console.WriteLine(name);
            Console.WriteLine(model);
        }
    }

    internal class Class3
    {
        static void Main()
        {
            bike b = new bike();
            b.getdata();
            
            bike b2 = new bike();
            Console.WriteLine("enter id");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price");
            int price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("name");
            string name=Console.ReadLine();
            Console.WriteLine("model");
            string model=Console.ReadLine();
            b2.getdata();
            Console.ReadLine();
        }
    }
}
*/