using System.Diagnostics;
using demo_22dth_n1_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace demo_22dth_n1_2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger1)
        {
            _logger = logger1;
            double tich = tich2so(3, 5);

        }

        int tich2so(int x, int z) {
            return x * z;
        }
        public IActionResult Index()
        {
            return View();
        }
        int tonghaiso(int a, int b) { 
            return a + b;
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
