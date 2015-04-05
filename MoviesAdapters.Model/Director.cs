using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAdapters.Model
{
    // one to many relationship
    public class Director
    {
        public int DirectorId { get; set; }
        public string Name { get; set; }
        public virtual List<Movie> Movies { get; set; }
    }
}
