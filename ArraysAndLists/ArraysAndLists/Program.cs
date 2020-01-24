using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a list named dinosaurs
            //Add 3 different dinosaur names to the list
            //print all 3 names from that list to the console - *using a loop*

            var dinosaurs = new List<string>();
            dinosaurs.Add("ankylosaurus");
            dinosaurs.Add("spinosaurus");
            dinosaurs.Add("stegosaurus");

            for (int i=0; i < dinosaurs.Count; i++)
            {
                Console.WriteLine(dinosaurs[i]);
            }
            
            foreach (var dino in dinosaurs)
            {
                Console.WriteLine(dino);
            }

            //Create an array (using inferred typing) named dogs of size 4 that will hold items of type string
            //add 4 names to the dogs array
            //using a for loop to print each dog name

            var dogs = new string[4];
            dogs[0] = "beagle";
            dogs[1] = "poodle";
            dogs[2] = "bulldog";
            dogs[3] = "lab";

            for (int i=0; i < dogs.Length; i++)
            {
                Console.WriteLine(dogs[i]);
            }

            foreach (var dog in dogs)
            {
                Console.WriteLine(dog);
            }


            //Fibonacci
            var fibonacciNumbers = new List<int> { 1, 1 };

            //using while
            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var num in fibonacciNumbers)
            {
                Console.WriteLine(num);
            }

            //using for
            var sum = 0;
            for (int i = 0; i < 18; i++)
            {
                sum = fibonacciNumbers[i] + fibonacciNumbers[i + 1];
                fibonacciNumbers.Add(sum);
            }
            foreach (var num in fibonacciNumbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
