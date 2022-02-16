using Bogus;
using Microsoft.AspNetCore.Mvc;
using RegisterAndLoginApp.Models;
using RegisterAndLoginApp.Services;

namespace RegisterAndLoginApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index(int productId,string productName,decimal productPrice,string productDescription)
        {
            HardCodedSampleDataRepository hardCodedSampleDataRepository = new HardCodedSampleDataRepository();
            return View(hardCodedSampleDataRepository.GetAllProducts());
        }
        public IActionResult Message()
        {
            return View("message");
        }
        public IActionResult Welcome(string name,int secretNumber=13)
        {
            ViewBag.Name = name;
            ViewBag.Secret = secretNumber;
            return View();
        }
    }
}
