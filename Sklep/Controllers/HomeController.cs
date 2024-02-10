using Microsoft.AspNetCore.Mvc;
using Sklep.Models;
using System.Diagnostics;

namespace Sklep.Controllers
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
            return View();
        }

        public IActionResult Privacy()
        {
            var people = new List<Person>()
            {
                new Person()
                {
                    Name= "Amadeusz",
                    Surname="Ferrari",
                    Age=35
                },
                new Person()
                {
                    Name="Jonatan",
                    Surname="Długołęcki",
                    Age=20
                }
            };
            return View(people);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}