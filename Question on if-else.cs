/*wap to accept 3 subject marks  and print total , per and grade.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class5
    {
        static void Main()
        {
            int m1,m2,m3,total;
            float per;
            Console.WriteLine("Enter Marks");
            m1 = Convert.ToInt32(Console.ReadLine());
            m2 = Convert.ToInt32(Console.ReadLine());
            m3 = Convert.ToInt32(Console.ReadLine());
            total = m1 + m2 + m3;
            per =(total * 100 / 300);
            Console.WriteLine("Percentage ="+per);
            Console.WriteLine("Total =" + total);
            if (per >60)
            {
                Console.WriteLine("1st Class");
            }
            if(per >75)
            {
                Console.WriteLine("Distinction");
            }
            if(per <50)
            {
                Console.WriteLine("Fail");
            }
            Console.ReadLine();
        }
    }
}
*/