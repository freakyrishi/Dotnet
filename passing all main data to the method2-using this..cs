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

        public void getdata(int empno, string empname,float salary)
        {
             this.empno = empno;
             this.empname = empname;
             this.salary = salary;
        }

        public void displaydata()
        {
            Console.WriteLine("empno " + empno);
            Console.WriteLine("empname " + empname);
            Console.WriteLine("salary " + salary);

        }

    }
     class Program
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