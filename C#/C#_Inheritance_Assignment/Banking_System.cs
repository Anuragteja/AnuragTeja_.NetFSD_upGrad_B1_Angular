using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Assignment
{
    public class Account
    {
        public double AccountNumber { get; set; }
        public double Balance { get; set; }

        public void CalculateInterest()
        {
            Console.WriteLine("Base account interest calculation");
        }
    }
    public class SavingsAccount : Account
    {
        public new void CalculateInterest()
        {
            Console.WriteLine("SavingsAccount interest calculation");
        }
    }

    public class CurrentAccount : Account
    {
        public new void CalculateInterest()
        {
            Console.WriteLine("CurrentAccount interest calculation");
        }
    }

    internal class Banking_System
    {
        static void Main(string[] args)
        {
            Account acc = new SavingsAccount();

            acc.CalculateInterest();   // Calls base method because of method hiding

            SavingsAccount sa = new SavingsAccount();
            sa.CalculateInterest();    // Calls derived method
        }
    }
}