using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class program
    {
        int id;
        string name;
        public program()
        {
            id= 0;
            name = "roshan";
        }
        public program(int id,string name)
        {
            this.id = id;
            this.name = name;
        }

        public void getdata()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Id =" + id);
            Console.WriteLine("Name =" + name);
        }
    }
    internal class Class6
    {
        static void Main()
        {

            program p1 = new program();
            p1.getdata();

            program p2 = new program();
            p2.getdata(1, "roshu");
        }



    }
}
