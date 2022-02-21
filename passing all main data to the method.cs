/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class employee
    {
        int empno;
        String empname;
        float salary;

        public void getdata(int a, string b,float c)
        {
             empno = a;
             empname = b;
             salary = c;
        }

        public void displaydata()
        {
            Console.WriteLine("empno " + empno);
            Console.WriteLine("empname " + empname);
            Console.WriteLine("salary " + salary);

        }

    }
    internal class Class1
    {
        static void Main()
        {
            employee emp = new employee();
            Console.WriteLine("enter id");
            int en=Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("enter name");
            string nm=Console.ReadLine();
            Console.WriteLine("enter salary");
            float sal=Convert.ToSingle(Console.ReadLine());

            emp.getdata(en, nm, sal);
            emp.displaydata();
            Console.ReadLine();

        }
    }
}
*/