/*create a structure student and accept values from the user

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
        struct student { 
            public string name; 
            public int age;
            public int id;

        }
        public static void Main()
        {
            student s1;
            Console.WriteLine("Enter Name");
            s1.name =Console.ReadLine();
            Console.WriteLine("Enter Age");
            s1.age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Id");
            s1.id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name = " + s1.name);
            Console.WriteLine("Age = "+s1.age);
            Console.WriteLine("ID = " + s1.id);

        }
    }
}*/
