using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;
using System.Globalization;

namespace RegisterAndLoginApp.Controllers
{
    public class MovieController : Controller
    {
        public IActionResult Index()
        {
            HardCodedSampleDataRepositoryMovie hardCodedSampleDataRepositoryMovie = new HardCodedSampleDataRepositoryMovie();
            
            return View(hardCodedSampleDataRepositoryMovie.GetAllMovies());
        }
        public IActionResult Message()
        {
            return View("message");
        }
        public IActionResult Welcome(string name, int secretNumber=18)
        {
            ViewBag.Name = name;
            ViewBag.SecretNumber = secretNumber;
            return View();
        }
    }
}
