/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class student
    {
        int rno;
        
        float sub1;
        float sub2; 
        float sub3;

        public void getdata()
        {
            Console.WriteLine("roll no");
            rno = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Enter Subject 1 mark");
            sub1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Subject 2 mark");
            sub2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter Subject 3 mark");
            sub3 = Convert.ToSingle(Console.ReadLine());
        }
        public void showdata()
        {
            float total = sub1 + sub2 + sub3;
            float per=(total/300)*100;
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("roll no=" + rno);
            
            Console.WriteLine("Total =" + total);
            Console.WriteLine("percentage =" + per);
        }
    }
    internal class Class2
    {
        static void Main()
        {
            student stud = new student();
            
            stud.getdata();
            stud.showdata();
            Console.ReadLine();
        }
    }
}
*/