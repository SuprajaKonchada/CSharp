using CustomFilters.Models;
using CustomFilters.CustomFiltersFolder;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustomFilters.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /*[CustomFiltersFolder.Action]*//*
        public string Index()
        {
            return "This is the Index action on the Home controller\n";
        }*/
        [Authorization]
        [CustomFiltersFolder.Exception]
        public IActionResult Privacy()
        {
            return View("Supraja");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}