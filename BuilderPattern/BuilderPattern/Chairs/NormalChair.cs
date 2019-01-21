using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Chairs
{
    public class NormalChair : IChair
    {
        public string Name => "Normal chair";

        public int Height => 90;
    }
}
