using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Optionals
{
    public class Photo : IOptional
    {
        public string PhotoDescription { get; private set; }
        public string Name => $"Photo depicting {PhotoDescription}";

        public Photo(string photoDescription)
        {
            this.PhotoDescription = photoDescription;
        }
    }
}
