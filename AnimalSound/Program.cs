using AnimalSound.Library;
using System;
using System.Collections.Generic;

namespace AnimalSounds
{

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
