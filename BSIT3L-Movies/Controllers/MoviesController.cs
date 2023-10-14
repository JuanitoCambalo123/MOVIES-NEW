using System;
using System.Collections.Generic;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
    public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;

        public MoviesController()
        {
            _movies = new List<MovieViewModel>
            {
new MovieViewModel { Id = 1, Name = "Titanic", Rating = "5", ReleaseYear = 1997, Genre = "Romance/Drama" },
new MovieViewModel { Id = 2, Name = "Inception", Rating = "4", ReleaseYear = 2010, Genre = "Science Fiction/Thriller" },
new MovieViewModel { Id = 3, Name = "The Shawshank Redemption", Rating = "5", ReleaseYear = 1994, Genre = "Drama" },
new MovieViewModel { Id = 4, Name = "John Wick: Chapter 4", Rating = "4", ReleaseYear = 2023, Genre = "Action" },
new MovieViewModel { Id = 5, Name = "The Lion King", Rating = "5", ReleaseYear = 1994, Genre = "Animation/Adventure" },
new MovieViewModel { Id = 6, Name = "Toy Story 4", Rating = "4", ReleaseYear = 2019, Genre = "Animation/Comedy" },
new MovieViewModel { Id = 7, Name = "The Dark Knight", Rating = "5", ReleaseYear = 2008, Genre = "Action/Crime" },
new MovieViewModel { Id = 8, Name = "Avengers: Endgame", Rating = "4", ReleaseYear = 2019, Genre = "Action/Adventure" },
new MovieViewModel { Id = 9, Name = "Forrest Gump", Rating = "5", ReleaseYear = 1994, Genre = "Drama/Romance" },
new MovieViewModel { Id = 10, Name = "The Matrix", Rating = "4", ReleaseYear = 1999, Genre = "Science Fiction/Action" },

            };
        }

        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "4", ReleaseYear = 2009, Genre = "Science Fiction/Action" };
            return View(movie);
        }

        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);
        }
    }
}
