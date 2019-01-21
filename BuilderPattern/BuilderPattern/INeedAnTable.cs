using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface INeedsAnDesk
    {
        INeedsAnOptional SetADesk(DeskType deskType, int width, int length, int height);
    }
}
