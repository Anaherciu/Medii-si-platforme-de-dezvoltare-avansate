using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalSound.Library
{
    internal class Cow : Animal
    { 
        public Cow(string type, string sound) : base(type, sound)
        {
            Type = type;
            Sound = sound;
        }
    }
}
