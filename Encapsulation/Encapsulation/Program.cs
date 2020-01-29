using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            var balance = new BankAccount();
            balance.Deposit(100);
            balance.WithDraw(58);
            balance.GetBalance();
        }
    }
}
