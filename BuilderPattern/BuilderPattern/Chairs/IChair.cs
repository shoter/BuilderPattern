using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Chairs
{
    public interface IChair
    {
        string Name { get; }

        /// <summary>
        /// Gets the height in centimeters.
        /// </summary>
        /// <value>
        /// The height in centimeters.
        /// </value>
        int Height { get; }
    }
}
