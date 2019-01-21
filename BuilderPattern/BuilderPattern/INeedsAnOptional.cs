using BuilderPattern.Optionals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public interface INeedsAnOptional
    {
        INeedsAnOptional AddOptional(IOptional optional);
        /// <summary>
        /// Sets the name of the employee that will be working on that Workplace.
        /// </summary>
        /// <param name="employeeName">Name of the employee.</param>
        /// <returns></returns>
        INeedsAnOptional SetEmployeeName(string employeeName);

        IWorkplace Build();
        
    }
}
