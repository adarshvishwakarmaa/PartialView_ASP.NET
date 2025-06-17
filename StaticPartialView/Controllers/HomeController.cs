using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using StaticPartialView.Models;

namespace StaticPartialView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Address address1 = new Address();
            address1.cname = "A";
            address1.Addres1 = "Goregaon";
            address1.Addres2 = "ADARSH";
            return View(address1);
        }

        public IActionResult AboutUs()
        {
            Address address1 = new Address();
            address1.cname = "ABC";
            address1.Addres1 = "Goregaon EAST"; 
            address1.Addres2 = "ADARSH VISHWAKARMA";
            return View(address1);
         
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
