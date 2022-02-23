/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class person
    {
         string name;
         int age;

        public void getdata1(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void show1()
        {
            Console.WriteLine("Name-" + name);
            Console.WriteLine("Age-" + age);
        }
    }
    public class student : person
    {
         string grade;
         int rno;

        public void getdata2(string grade, int rno)
        {
            this.grade = grade;
            this.rno = rno;
        }

        public void show2()
        {
            Console.WriteLine("grade-" + grade);
            Console.WriteLine("rno-" + rno);
        }
    }
    public class employee : person
    {
         string position;
         int salary;

        public void getdata3(string position, int salary)
        {
            this.position = position;
            this.salary = salary;
        }

        public void show3()
        {
            Console.WriteLine("position-" + position);
            Console.WriteLine("salary-" + salary);
        }
    }
    internal class hierarchical_inheritance
    {
        
       public static void Main()
        {
            student stu = new student();
            stu.getdata1("Rohit",9);
            stu.getdata2("A",101);
            stu.show1();    
            stu.show2();

            Console.WriteLine("-------------------------------------------------------------------------------------------");

            employee stu1 = new employee();
            stu1.getdata1("Rohit", 9);
            stu1.getdata3("Manager", 150000);
            stu1.show1();
            stu1.show3();

            Console.ReadLine();

        }
    }
}
*/