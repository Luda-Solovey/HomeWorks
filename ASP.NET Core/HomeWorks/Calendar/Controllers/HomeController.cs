using System.Diagnostics;
using DependencyInjHW.Models;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjHW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
