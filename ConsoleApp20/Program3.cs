/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    class Bank
    {
       public double balance=100;//private field
        public void Deposit(double amount)
        {
            if(amount>0)
            {
                balance += amount;
            }
        }
        public void Showbalance()
        {
            Console.WriteLine($"Balance is: {balance}");
        }

    }
    internal class Program3
    {
        static void Main()
        {
            Bank bank = new Bank();
            Console.WriteLine(bank.balance);
            bank.Deposit(1000);
           bank.Showbalance();
        }
    }
}
*/