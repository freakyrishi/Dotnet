/*write a program find percentage and total marks of 3 subjects

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main()
        {
            int mark1,mark2,mark3, total;
            float per;
            Console.WriteLine("Enter marks of three subjects");
            mark1 =Convert.ToInt32(Console.ReadLine());
            mark2 = Convert.ToInt32(Console.ReadLine());
            mark3 = Convert.ToInt32(Console.ReadLine());
            total = mark1 + mark2 + mark3;
            per=((float)total*100)/ 300;
            Console.WriteLine("Total ="+total);
            Console.WriteLine("Percentages =" + per);
            Console.ReadLine();
        }
    }
}*/
