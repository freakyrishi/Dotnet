/*

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        static void Main()
        {
            int num1, num2,res=0;
            char choice;
            Console.WriteLine("Press + for addition");
            Console.WriteLine("Press - for addition");
            Console.WriteLine("Press * for addition");
            Console.WriteLine("Press / for addition");
            num1=Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            res = Convert.ToInt32(Console.ReadLine());
            choice =Convert.ToChar(Console.ReadLine());

            switch (choice)
            {
                case '+':
                    res = num1 + num2;
                    break;

                case '-':
                    res = num1 - num2;
                    break;

                case '*':
                    res = num1 * num2;
                    break;

                case '/':
                    res = num1 / num2;
                    break;

                default:  
                    Console.WriteLine("Invalid operator");
                    break;
            }
            Console.WriteLine("Result = ",+res);
            Console.ReadLine();
        }
    }
}*/
