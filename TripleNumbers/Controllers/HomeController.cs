using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TripleNumbers.Models;

namespace TripleNumbers.Controllers {
    public class HomeController : Controller {
        [HttpGet]
        public IActionResult Index() {
            return View(new HomeModel());
        }

        [HttpPost]
        public IActionResult Index(HomeModel model) {
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}