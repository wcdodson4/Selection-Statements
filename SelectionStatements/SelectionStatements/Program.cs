using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number.");
            var favNumber = 4;
            var guess = int.Parse(Console.ReadLine());
            if (guess < favNumber)
                Console.WriteLine("Too low. Continue?");
            else if (guess > favNumber)
                Console.WriteLine("Too high. Continue?");
            else
                Console.WriteLine("Nevermind.");
        }
    }
}
