/* find area of circumference and area of circle

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class1
    {
       static void Main()
        {
            int r;
            float area, circumference;
            Console.WriteLine("enter radious");
            r=Convert.ToInt32(Console.ReadLine());
            area = (float)3.14f * r * r;
            circumference = (float)2 * 3.14f * r;           
            Console.WriteLine("Area =" + area);
            Console.WriteLine("Circumference =" + circumference);
            Console.ReadLine();    
        }

    }
}*/
