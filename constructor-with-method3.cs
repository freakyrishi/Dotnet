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
        int id;
        string name;
        int salary;
        string grade;

        public employee()
        {
            id = 1;
            name = "Rohit";
            salary = 15000;
            grade = "manager";

        }

        public void employ(int id,string name,int salary,string grade)
        {
            this.id = id;
            this.name = name;   
            this.salary = salary;
            this.grade = grade;
        }
        public void getdata ()
        {
            Console.WriteLine("Enter "+id);
            Console.WriteLine("Enter "+name);
            Console.WriteLine("Enter "+salary);
            Console.WriteLine("Enter "+grade);

        }
    }
    internal class constructor_with_method3
    {
        static void Main()
        {
            employee emp = new employee();
            emp.getdata();

            employee emp2 = new employee();
            Console.WriteLine("enter id");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter salary");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter name");
            string name=Console.ReadLine();
            Console.WriteLine("enter grade");
            string grade = Console.ReadLine();

            emp2.getdata();
            Console.ReadLine();
        }
    }
}*/
