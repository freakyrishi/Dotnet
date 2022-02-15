/*

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
            int num; 
            int n1, n2, n3, rev,orignum;
            Console.WriteLine("Enter Number");
            num = Convert.ToInt32(Console.ReadLine());  

            orignum = num;
            n1 = num % 10;
            num = num / 10;
            n2 = num % 10;
            num = num / 10;
            n3 = num % 10;
            rev = n1 * 100 + n2 * 10 + n3 * 1;
            if (orignum == rev)
            {
                Console.WriteLine("palindrom number");
            }
            else
            {
                Console.WriteLine("Not palindrom number");
            }
            
        }
    }
}*/
