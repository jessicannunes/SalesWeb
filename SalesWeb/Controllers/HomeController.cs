using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;
using System.Diagnostics;

namespace SalesWeb.Controllers
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

        public IActionResult About()
        {
            ViewData["message"] = "Sales Web App";
            
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
