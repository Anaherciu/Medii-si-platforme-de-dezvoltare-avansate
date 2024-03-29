using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound.Library
{
    public class Animal
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
}
