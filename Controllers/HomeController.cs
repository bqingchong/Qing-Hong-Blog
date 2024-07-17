using Microsoft.AspNetCore.Mvc;
using Qing_Hong_Blog.Models;
using System.Diagnostics;

namespace Qing_Hong_Blog.Controllers
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

        public IActionResult Handouts()
        {
            return View();
        }

        public IActionResult Notes()
        {
            return View();
        }

        public IActionResult Articles()
        {
            return View();
        }
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult W1D1()
        {
            return View("Views/Physics_Week_Challenge/W1D1.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
