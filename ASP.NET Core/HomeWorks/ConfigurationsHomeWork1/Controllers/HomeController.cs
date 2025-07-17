using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ConfigurationsHomeWork1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
