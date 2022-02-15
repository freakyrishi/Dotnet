/*create a structure student and accept values from the user

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        struct company
        {
            public string Name;
            public string Description;
            public string Title;
            public int rank;
        }
        public static void Main()
        {
            company c1;
            Console.WriteLine("Company Name");
            c1.Name=Console.ReadLine();
            Console.WriteLine("Discription");
            c1.Description=Console.ReadLine();
            Console.WriteLine("Title");
            c1.Title=Console.ReadLine();
            Console.WriteLine("Rank");
            c1.rank = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Name = " + c1.Name);
            Console.WriteLine("Description = " + c1.Description);
            Console.WriteLine("Title = " + c1.Title);
            Console.WriteLine("Rank = " + c1.rank);

        }
    }
}*/
