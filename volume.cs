/*wap to accept length and breadth,height of a and print volume

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class area_of_rectangle
    {
        static void Main()
        {
            int length, breadth,volume,height;
            Console.WriteLine("enter length");
            length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter breadth");       
            breadth=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter height");
            height = Convert.ToInt32(Console.ReadLine());
            volume = length * breadth*height;
            Console.WriteLine("volume =" + volume);
            Console.ReadLine();
        }
    }
}*/
