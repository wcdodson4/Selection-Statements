using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try and guess my favorite number.");
            var favNumber = 32;
            var guess = int.Parse(Console.ReadLine());

            do
            {
                if (guess < favNumber)
                {
                    Console.WriteLine("Too low.");
                    Console.WriteLine("Guess again? (Y or N)");
                    var guessAgain = Console.ReadLine();
                    if (guessAgain == "Y")
                    {
                        Console.WriteLine("Guess another number.");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == 32)
                        {
                            Console.WriteLine("Yessir!");
                        }
                    }
                    else
                        guess = 32;
                }
                else if (guess > favNumber)
                {
                    Console.WriteLine("Too high.");
                    Console.WriteLine("Guess again? (Y or N)");
                    var guessAgain = Console.ReadLine();
                    if (guessAgain == "Y")
                    {
                        Console.WriteLine("Guess another number.");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == 32)
                        {
                            Console.WriteLine("Yessir!");
                        }
                    }
                    else
                        guess = 32;
                }

                else if (guess == 32)
                {
                    Console.WriteLine("Yessir!");
                }
            }
            while (guess != favNumber);
        }
    }
}
