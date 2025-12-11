using System;
using System.Collections.Generic;

namespace OldMacDonaldChallenge.DataDrivenSolution
{
    public class Animal
    {
        public string Name { get; }
        public string Sound { get; }

        public Animal(string name, string sound)
        {
            Name = name;
            Sound = sound;
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var animals = new List<Animal>
            {
                new Animal("cow", "moo"),
                new Animal("duck", "quack"),
                new Animal("dog", "woof"),
                new Animal("sheep", "bee"),
                new Animal("pig", "oink")
            };

            foreach (var animal in animals)
            {
                PrintVerse(animal);
            }
        }

        private static void PrintVerse(Animal animal)
        {
            Console.WriteLine("Old MacDonald had a farm, E-I-E-I-O");
            Console.WriteLine($"And on his farm he had a {animal.Name}, E-I-E-I-O");
            Console.WriteLine($"With a {animal.Sound}-{animal.Sound} here and a {animal.Sound}-{animal.Sound} there");
            Console.WriteLine($"Here a {animal.Sound}, there a {animal.Sound}, ev'rywhere a {animal.Sound}-{animal.Sound}");
            Console.WriteLine("Old MacDonald had a farm, E-I-E-I-O");
            Console.WriteLine();
        }
    }
}