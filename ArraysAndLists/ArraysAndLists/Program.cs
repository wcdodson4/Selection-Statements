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

        }
    }
}
