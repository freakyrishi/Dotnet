/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class place
    {
        int rank;
        string name;
        string monument;

        public void data()
        {
            rank = 1;
            name = "nagpur";
            monument = "Ganesh Tekdi Temple";
        }
        public void data(int rank)
        {
            this.rank = rank;
        }
        public void data(int rank,string name)
        {
            this.rank = rank;
            this.name = name;   
        }
        public void data(int rank,string name,string monument)
        {
            this.rank = rank;
           this.name = name;
            this.monument = monument;
        }
        public void display()
        {
            Console.WriteLine("Rank= " + rank);
            Console.WriteLine("name =" + name);
            Console.WriteLine("Monumnet= "+monument);
        }
    }
    internal class Class1
    {
        static void Main()
        {
            place p1 = new place();
            p1.data();
            p1.display();

            place p2 = new place();
            p2.data(1);
            p2.display();

            place p3 = new place();
            p3.data(66,"Nagpur");
            p3.display();
            

            place p4 = new place();
            p4.data(88,"Bhopal","Bidla Temple");
            p4.display();
            Console.ReadLine();
        }
    }
}*/
