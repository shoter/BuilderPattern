using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface IWorkplace
    {
        /// <summary>
        /// Writes to standard output all information about this workplace.
        /// </summary>
        void Describe();
    }
}
