using MoviesAdapters.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAdapters.Adapters.Interfaces
{
    public interface IDirectorAdapter
    {
        int AddDirector(int id);
        int AddDirector(Director director);
        int EditDirector(int id);
        int EditDirector(Director director);
        int DeleteDirector();

    }
}
