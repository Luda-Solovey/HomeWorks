using ConfigurationsHomeWork2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConfigurationsHomeWork2.Controllers
{
    public class EmailSenderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SendEmail() 
        {
            return View();
        }


        [HttpPost]
        public IActionResult SendEmail(EmailModel message)
        {
            return View();
        }
    }
}
