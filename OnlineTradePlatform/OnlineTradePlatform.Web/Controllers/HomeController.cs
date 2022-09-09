using Microsoft.AspNetCore.Mvc;
using OnlineTradePlatform.Web.Models;
using System.Diagnostics;

namespace OnlineTradePlatform.Web.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ILogger<HomeController> logger) {}

        public IActionResult Index()
        {
            return View();
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