using _08FormsAndValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;
using _08FormsAndValidation.Infrastructure;

namespace _08FormsAndValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View(new Client() { Date = DateTime.Now});
        }

        [HttpPost]
        public IActionResult Register(Client client)
        {
            bool isDateValid = ValidateHelper.ValidateDate(client.Date);
            if (!isDateValid)
            {
                ModelState.AddModelError("Date", "Registration date can be only in a feature and on work day");
            }

            if (ModelState.IsValid)
            {                
                return View("Success", client);
            }

            return View(client);        
        }
    }
}
