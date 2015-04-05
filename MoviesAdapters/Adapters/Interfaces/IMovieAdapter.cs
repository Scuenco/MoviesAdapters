using MoviesAdapters.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAdapters.Adapters.Interfaces
{
    public interface IMovieAdapter
    {
        /// <summary>
        /// Displays all directors and their movies in Index view
        /// </summary>
        /// <returns></returns>
        List<Director> GetAll();
        int AddMovie(int id);
        int AddMovie(Movie movie);
        int EditMovie(int id);
        int EditMovie(Movie movie);
        int DeleteMovie();

    }
}
