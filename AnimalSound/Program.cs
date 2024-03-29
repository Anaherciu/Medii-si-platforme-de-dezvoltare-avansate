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
                new Cat("Cat", "Meow"),
                new Dog("Dog", "Woof"),
                new Cow("Cow", "Moo")
            };

            foreach (var animal in animals)
            {
                animal.MakeSound();
            }

            Console.ReadLine(); 
        }
    }
}
