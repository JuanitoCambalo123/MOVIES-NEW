using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BSIT3L_Movies.Models;
using System.Collections.Generic;

namespace BSIT3L_Movies.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly List<MovieViewModel> _movies;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        _movies = new List<MovieViewModel>
        {
                new MovieViewModel { Id = "1", Name = "The Fast and the Furious", Rating = "5",
                                  ReleaseYear = 2001, Genre = "Adventure/Crime",
                                  ImagePath = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcRd7yNHzWZnaPTjxzZUaZO3WOKauO7kUBCCe_ISKDN5WxUUfR82",
                                  VideoPath = "https://www.youtube.com/embed/XnM8rVqr0XY?si=4dnThXOtX0FxMfW7"
                                },
                new MovieViewModel { Id = "2", Name = "2 Fast 2 Furious", Rating = "5",
                                  ReleaseYear = 2003, Genre = "Adventure/Crime ",
                                  ImagePath = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQSudidhR3TCIzRUMURMV-cOjOYzNH7oTrlVJAUs-goIdhgxKKD",
                                  VideoPath = "https://www.youtube.com/embed/ASWNjTh6izo?si=pC6UnKQs7Q9ZIBnu"
                                },
                new MovieViewModel { Id = "3", Name = "The Turbo Charged Prelude for 2 Fast 2 Furious", Rating = "5",
                                  ReleaseYear = 2003, Genre = "Adventure/Crime",
                                  ImagePath = "https://m.media-amazon.com/images/M/MV5BY2Y2ODBjN2QtZTE3OS00NDliLWIwZjktMmY5MmQyZDMzNWMyXkEyXkFqcGdeQXVyNjUyODQ4NzE@._V1_FMjpg_UX1000_.jpg",
                                  VideoPath = "https://www.youtube.com/embed/9ON6MjBsWek?si=t5g10lzjLAVIRRco"
                                },
                new MovieViewModel { Id = "4", Name = "The Fast and the Furious: Tokyo Drift", Rating = "5",
                                  ReleaseYear = 2006, Genre = "Adventure/Crime",
                                  ImagePath = "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcQprJWtJkNo7sQtX-vTxOJ6v7M8LNcCDfq1JreVXrYFaskoSBnu",
                                  VideoPath = "https://www.youtube.com/embed/4bFTNAe_ZWc?si=PYfnQZn1A8OzIBvX"
                                },
                new MovieViewModel { Id = "5", Name = "Fast & Furious", Rating = "5",
                                  ReleaseYear = 2009, Genre = "Adventure/Crime",
                                  ImagePath = "https://upload.wikimedia.org/wikipedia/en/8/8f/Fast_and_Furious_Poster.jpg",
                                  VideoPath = "https://www.youtube.com/embed/7aGvYMcorR0?si=Iw9kwB2yoEs5HcWK"
                                },



                new MovieViewModel { Id = "6", Name = "Los Bandoleros", Rating = "5",
                                  ReleaseYear = 2009, Genre = "Adventure/Crime",
                                  ImagePath = "https://upload.wikimedia.org/wikipedia/en/0/0a/Los_Bandoleros_FilmPoster.jpeg",
                                  VideoPath = "https://www.youtube.com/embed/oBSP4Kt3-Ik?si=-n0HDkko6C4FL319"
                                },
                new MovieViewModel { Id = "7", Name = "Fast Five", Rating = "5",
                                  ReleaseYear = 2011, Genre = "Adventure/Crime",
                                  ImagePath = "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQCyje37BfTWoxZEgBY4K08OxboplfGHL-IgLPwasigNdJl7Xih",
                                  VideoPath = "https://www.youtube.com/embed/hvXeMqLaaMA?si=RyBdIqinU1KB1QvR"
                                },
                new MovieViewModel { Id = "8", Name = "Fast & Furious 6", Rating = "5",
                                  ReleaseYear = 2013, Genre = "Adventure/Crime",
                                  ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ4d8v5B9v41UfP7tKwsQ_H-lyRsz7FFkLbejVwe8riMq4ZOacf",
                                  VideoPath = "https://www.youtube.com/embed/LOZqWtG41sE?si=HprjNWgsMDt9mS8C"
                                },
                new MovieViewModel { Id = "9", Name = "Furious 7", Rating = "5",
                                  ReleaseYear = 2015, Genre = "Adventure/Crime ",
                                  ImagePath = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS_mnZjW9M72N74nLri81ZhO7GE3Z3c8S82Z_J9dUNoH3THriCA",
                                  VideoPath = "https://www.youtube.com/embed/S5ZeVoJXq2c?si=Hac1-IQhmCBNgFif"
                                },
                new MovieViewModel { Id = "10", Name = "The Fate of the Furious", Rating = "5",
                                  ReleaseYear = 2017, Genre = "Adventure/Crime ",
                                  ImagePath = "https://images-na.ssl-images-amazon.com/images/M/MV5BMjMxODI2NDM5Nl5BMl5BanBnXkFtZTgwNjgzOTk1MTI@._V1_SY1000_CR0,0,631,1000_AL_.jpg",
                                  VideoPath = "https://www.youtube.com/embed/In52HZ25ryU?si=rbyl_2pqy1wiBCQV"
                                },
                new MovieViewModel { Id = "11", Name = "F9", Rating = "5",
                                  ReleaseYear = 2021, Genre = "Adventure/Crime ",
                                  ImagePath = "https://m.media-amazon.com/images/M/MV5BMjI0NmFkYzEtNzU2YS00NTg5LWIwYmMtNmQ1MTU0OGJjOTMxXkEyXkFqcGdeQXVyMjMxOTE0ODA@._V1_FMjpg_UX1000_.jpg",
                                  VideoPath = "https://www.youtube.com/embed/jS4DJRj6tBo?si=NbG3mfUmsL-kWxfa" 
                                },
                new MovieViewModel { Id = "12", Name = "Fast X", Rating = "5",
                                  ReleaseYear = 2023, Genre = "Adventure/Crime ",
                                  ImagePath = "https://movies.universalpictures.com/media/fstx-montage1sheet2-rgb-1-64108e93e63dd-1.jpg",
                                  VideoPath = "https://www.youtube.com/embed/tbzb8cNfeeY?si=trG3XNF1chzpx5gM"
                                },

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