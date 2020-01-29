using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class BankAccount
    {
        private double Balance = 0;

        public double Deposit(double depositAmount)
        {
            return Balance += depositAmount;
        }

        public double WithDraw(double withdrawAmount)
        {
            return Balance -= withdrawAmount;
        }

        public void GetBalance()
        {
            Console.WriteLine($"You have ${Balance} in your bank account.");
        }
    }
}
