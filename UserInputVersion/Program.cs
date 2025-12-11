using System;
using System.Collections.Generic;

namespace OldMacDonaldChallenge.UserInputVersion
{
    public abstract class Animal
    {
        public string Name { get; }

        protected Animal(string name)
        {
            Name = name;
        }

        public abstract string Sound { get; }

        public virtual void SingSong()
        {
            Console.WriteLine("Old MacDonald had a farm, E-I-E-I-O");
            Console.WriteLine("And on his farm he had a " + Name + ", E-I-E-I-O");
            Console.WriteLine("With a " + Sound + "-" + Sound + " here and a " + Sound + "-" + Sound + " there");
            Console.WriteLine("Here a " + Sound + ", there a " + Sound + ", everywhere a " + Sound + "-" + Sound);
            Console.WriteLine("Old MacDonald had a farm, E-I-E-I-O");
            Console.WriteLine(); 
        }
    }

    public class GenericAnimal : Animal
    {
        private readonly string _sound;

        public GenericAnimal(string name, string sound)
            : base(name)
        {
            _sound = sound;
        }

        public override string Sound
        {
            get { return _sound; }
        }
    }

    public static class AnimalFactory
    {
        public static List<Animal> CreateDefaultAnimals()
        {
            var animals = new List<Animal>();

            animals.Add(new GenericAnimal("cow", "moo"));
            animals.Add(new GenericAnimal("duck", "quack"));
            animals.Add(new GenericAnimal("dog", "woof"));
            animals.Add(new GenericAnimal("sheep", "baa"));
            animals.Add(new GenericAnimal("pig", "oink"));

            return animals;
        }
    }

    public static class AnimalInput
    {
        public static void AddUserAnimals(List<Animal> animals)
        {
            Console.WriteLine("You can add your own animals to Old MacDonald's farm.");
            Console.WriteLine("Leave the animal name empty and press Enter when you are done.\n");

            while (true)
            {
                Console.Write("Animal name: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("\nNo name entered. Finished adding animals.\n");
                    break;
                }

                Console.Write("Sound for the " + name + ": ");
                string sound = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(sound))
                {
                    Console.WriteLine("Sound cannot be empty. Animal not added.\n");
                    continue;
                }

                animals.Add(new GenericAnimal(name, sound));
                Console.WriteLine("Added " + name + " with sound \"" + sound + "\".\n");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            var animals = AnimalFactory.CreateDefaultAnimals();

            AnimalInput.AddUserAnimals(animals);

            Console.WriteLine("=== Old MacDonald's Farm ===\n");

            foreach (var animal in animals)
            {
                animal.SingSong();
            }

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
