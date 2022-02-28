/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class account
    {
        public int accno;
        public int balance=1000;

        public virtual string deposit(int accno,int amount)
        {
            return "deposit method of account class";
        }

        public string showbalance()
        {
            return "balance amount " + balance;
        }
    }

    class current : account
    {
        public override string deposit(int accno, int amount)
        {
            this.accno=accno;

            balance = balance + amount;
            return "amount deposite successfully in current class";
        }
    }
    internal class run_time_difficult_program
    {
        public static void Main()
        {
            account act = new current();
            Console.WriteLine("enter account no ");
            int actno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter amount to be deposited ");
            int amount = Convert.ToInt32(Console.ReadLine());

            String res = act.deposit(actno, amount);
            Console.WriteLine("account no is " + act.accno);
            Console.WriteLine(res);
            res = act.showbalance();
            Console.WriteLine(res);


        }
    }
}*/
