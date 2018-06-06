using ProductProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductProject.ViewModels;

namespace ProductProject.Controllers
{
    public class MoviesController : Controller
    {
        public ViewResult Index()
        {
            var movies = GetMovies();
            return View(movies);
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            var customers = new List<Customer>
            {
                new Customer() { Name = "Customer 1"},
                new Customer() { Name = "Customer 2"}
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie {Id=1, Name="Schindler' s List"},
                new Movie {Id=2, Name="Pursuit of Happiness"}
            };
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);
        }
    }
}