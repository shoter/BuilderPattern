using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Optionals
{
    public class Flower : IOptional
    {
        public string Color { get; private set; }

        public string Name => $"{Color} Flower";
        
        public Flower(string color)
        {
            this.Color = color;
        }
    }
}
