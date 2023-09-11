using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TripleNumbers.Models;
using TripleNumbers.Services;

namespace TripleNumbers.Controllers {
    public class HomeController : Controller {
        private readonly NumberService numberService;

        public HomeController(NumberService numberService) {
            this.numberService = numberService;
        }

        [HttpGet]
        public IActionResult Index() {
            return View(new HomeModel());
        }

        [HttpPost]
        public IActionResult Index(HomeModel model) {
            if (ModelState.IsValid) {
                if (model.Input != null && numberService.TryGetTripleIntegers(model.Input, out var output)) {
                    model.Output = output;
                }
                else {
                    ModelState.AddModelError(nameof(HomeModel.Input), "Please provide a sequence of numbers in the format [1,3,2,3,4,3,5]");
                }
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}