using MoviesAdapters.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;// added
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesAdapters.Data
{
    public static class Seeder
    {
        public static void Seed(ApplicationDbContext db, bool movies = true, bool directors = true) 
        {
            if (directors) SeedDirectors(db);
            if (movies) SeedMovies(db);
        }
        private static void SeedMovies(ApplicationDbContext db)
        {
            db.Movies.AddOrUpdate(x => x.MovieId,
                new Movie() { MovieId = 1, Title = "Unbroken", DateReleased = DateTime.Now, DirectorId = 2 },
                new Movie() { MovieId = 2, Title = "Taken 1", DateReleased = DateTime.Now.AddYears(-3), DirectorId = 1 },
                new Movie() { MovieId = 3, Title = "Taken 2", DateReleased = DateTime.Now.AddYears(-2), DirectorId = 1 },
                new Movie() { MovieId = 4, Title = "Into The Woods", DateReleased = DateTime.Now.AddYears(-1), DirectorId = 2 },
                new Movie() { MovieId = 5, Title = "Taken 3", DateReleased = DateTime.Now, DirectorId = 1 },
                new Movie() { MovieId = 6, Title = "Superman", DateReleased = DateTime.Now.AddYears(-20), DirectorId = 3 }
                );
        }
        private static void SeedDirectors(ApplicationDbContext db)
        {
            db.Directors.AddOrUpdate(x => x.DirectorId,
                new Director() { DirectorId = 1, Name = "S. Spielberg"},
                new Director() { DirectorId = 2, Name = "A. Jolie"},
                new Director() { DirectorId = 3, Name = "P. Jackson"}
                );
        }
    }
}
