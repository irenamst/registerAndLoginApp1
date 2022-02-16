using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;
using System.Globalization;

namespace RegisterAndLoginApp.Controllers
{
    public class AirlineTicketController : Controller
    {
        public IActionResult Index()
        {
            HardCodedSampleDataRepositoryAirlineTicket hardCodedSampleDataRepositoryAirlineTicket = new HardCodedSampleDataRepositoryAirlineTicket();
            return View(hardCodedSampleDataRepositoryAirlineTicket.GetAllAirlineTickets());
        }
        public IActionResult Message()
        {
            return View("message");
        }
        public IActionResult Welcome(string name, int secretNumber=17)
        {
            ViewBag.Name = name;
            ViewBag.SecretNumber = secretNumber;
            return View();
        } 
    }
}
