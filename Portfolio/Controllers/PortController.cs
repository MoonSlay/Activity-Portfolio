using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class PortController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Education()
        {
            return View();
        }

        public IActionResult Hobbies()
        {
            return View();
        }
    }
}
