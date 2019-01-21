using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Chairs
{
    public class BlackChair : IChair
    {
        public string Name => "Black chair";

        public int Height => 100; 
    }
}
