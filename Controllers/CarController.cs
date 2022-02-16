using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;
using System.Globalization;

namespace RegisterAndLoginApp.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            HardCodedSampleDataRepositoryCar hardCodedSampleDataRepositoryCar = new HardCodedSampleDataRepositoryCar(); 
            return View(hardCodedSampleDataRepositoryCar.GetAllCars());
        }
        public IActionResult Message()
        {
            return View("message");
        }
        public IActionResult Welcome(string name, int secretNumber=19)
        {
            ViewBag.Name = name;
            ViewBag.SecretNumber = secretNumber;
            return View();
        }
    }
}
