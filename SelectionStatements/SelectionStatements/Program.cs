using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {   ///do-while loop
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

            //syntax sugar exercise

            //original code:
            //int answer = 4;
            //string response;

            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + "is less than nine";
            //}

            //modified code:
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";
        
            //loops
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }
        }

    }
}
