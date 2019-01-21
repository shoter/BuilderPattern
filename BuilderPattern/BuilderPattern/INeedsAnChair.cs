using BuilderPattern.Chairs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface INeedsAnChair
    {
        INeedsAnDesk SetChair(IChair chair);
    }
}
