using MoviesAdapters.Data;
using MoviesAdapters.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MoviesAdapters.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            // display all directors and their movies in Index view
            List<Director> model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                //pull out all directors from db and store them on a list
                model = db.Directors.Include("Movies").ToList();
            }
            return View(model);
        }
        public ActionResult Details(int id) //id is DirectorId
        {
            ViewBag.Message = "Details";
            Director model;
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Directors.Include("Movies").FirstOrDefault(x => x.DirectorId == id);
            }
            return View(model);
        }
        public ActionResult AddMovie(int id) //id is DirectorId
        {
            ViewBag.Message = "Add A Movie";
            Movie model = new Movie()
            {
                DirectorId = id
            };
            return View(model);
        }

        [HttpPost]
        public ActionResult AddMovie(Movie movie)
        {
            using (ApplicationDbContext db = new ApplicationDbContext()) 
            {
                db.Movies.Add(movie);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public ActionResult EditMovie(int id) //id is MovieId
        {
            ViewBag.Message = "Edit A Movie";
            Movie model;
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                model = db.Movies.FirstOrDefault(x => x.MovieId == id);
            }
            return View("AddMovie", model); //shares with the AddMovie view
        }

        [HttpPost]
        public ActionResult EditMovie(Movie movie)
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Movie model = db.Movies.FirstOrDefault(x => x.MovieId == movie.MovieId);
                if (model != null)
                {
                    model.Title = movie.Title;
                    model.DateReleased = movie.DateReleased;
                    db.SaveChanges();
                }
            }
            return RedirectToAction("Index");
        }

        public ActionResult DeleteMovie(int id) //id is MovieId
        {
            using (ApplicationDbContext db = new ApplicationDbContext())
            {
                Movie model = db.Movies.FirstOrDefault(x => x.MovieId == id);
                db.Movies.Remove(model);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}