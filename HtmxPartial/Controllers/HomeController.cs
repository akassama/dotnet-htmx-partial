using HtmxPartial.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HtmxPartial.Controllers
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

        [HttpPost]
        public IActionResult Index(FormModel formModel)
        {
            if (ModelState.IsValid)
            {
                //valid post, do more logic here

                TempData["Message"] = "Form processed successfully";
                return View();
            }

            //get the partial view to display in form
            var partialSelected = formModel.SelectInput.ToLower() == "one" ? "_InputOnePartial" : "_InputTwoPartial";

            return View(formModel);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
