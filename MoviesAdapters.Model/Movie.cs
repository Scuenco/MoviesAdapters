using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAdapters.Model
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Title { get; set; }
        public DateTime DateReleased { get; set; }
        public int DirectorId { get; set; }
        public virtual Director Director { get; set; }
    }
}
