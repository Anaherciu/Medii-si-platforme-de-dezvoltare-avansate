using System;
using System.Collections.Generic;

namespace AnimalSounds
{
    class Animal
    {
        public string Type { get; set; }
        public string Sound { get; set; }
        public Animal(string type, string sound)
        {
            Type = type;
            Sound = sound;
        }

        public void MakeSound()
        {
            Console.WriteLine($"{Type} makes sound: {Sound}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>
            {
                new Animal("Cat", "Meow"),
                new Animal("Dog", "Woof"),
                new Animal("Cow", "Moo")
            };

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            Console.ReadLine(); 
        }
    }
}
