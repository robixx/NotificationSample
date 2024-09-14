using Microsoft.AspNetCore.Mvc;

namespace NotificationSample.Controllers
{
    public class ModulesController : Controller
    {
        [HttpGet]
        public IActionResult Module1()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Module2()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Module3()
        {
            return View();
        }
    }
}
