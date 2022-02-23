/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class rectangle
    {
        float length;
        float width;
        float height;   

        public void getdata()
        {
            Console.WriteLine("Enter length");
            length=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Width");
            width = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter height");
            height = Convert.ToSingle(Console.ReadLine());
        }

        public void showarea()
        {
            float area = length * width;
            Console.WriteLine("area ="+area);
        }
        public void showvolumn()
        {
            float volumn = length * width*height;
            Console.WriteLine("volumn =" + volumn);
        }

    }
    internal class Class1
    {
        static void Main()
        {
            rectangle rect = new rectangle();
            rect.getdata();
            rect.showarea();
            rect.showvolumn();
            Console.ReadLine();
        }
    }
}
*/