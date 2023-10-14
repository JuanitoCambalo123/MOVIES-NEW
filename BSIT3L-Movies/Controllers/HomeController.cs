using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<MovieViewModel> _movies;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _movies = new List<MovieViewModel>
            {


new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama" },
new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller" },
new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama" },
new MovieViewModel { Id = 4, Name = "John Wick: Chapter 4", Rating = "4", ReleaseYear = 2023, Genre = "Action" },
new MovieViewModel { Id = 5, Name = "The Avengers", Rating = "4", ReleaseYear = 2012, Genre = "Action/Sci-Fi" },
new MovieViewModel { Id = 6, Name = "Avatar", Rating = "4", ReleaseYear = 2009, Genre = "Science Fiction/Action" },
new MovieViewModel { Id = 7, Name = "Interstellar", Rating = "4", ReleaseYear = 2014, Genre = "Science Fiction/Drama" },
new MovieViewModel { Id = 8, Name = "The Matrix", Rating = "4", ReleaseYear = 1999, Genre = "Science Fiction/Action" },
new MovieViewModel { Id = 9, Name = "The Godfather", Rating = "5", ReleaseYear = 1972, Genre = "Crime/Drama" },
new MovieViewModel { Id = 10, Name = "Pulp Fiction", Rating = "4", ReleaseYear = 1994, Genre = "Crime/Drama" },

            };
        }

        public IActionResult Index()
        {
            return View(_movies);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
