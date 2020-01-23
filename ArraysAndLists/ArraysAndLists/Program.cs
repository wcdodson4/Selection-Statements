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
            
            foreach (var dino in dinosaurs)
            {
                Console.WriteLine(dino);
            }
        }
    }
}
