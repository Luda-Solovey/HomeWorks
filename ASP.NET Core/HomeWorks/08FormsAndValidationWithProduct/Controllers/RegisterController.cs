using _08FormsAndValidation.Infrastructure;
using _08FormsAndValidation.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace _08FormsAndValidation.Controllers
{
    public class RegisterController : Controller
    {
        [DataAboutActions]
        [HttpGet]
        public IActionResult Register()
        {
            return View(new RecordViewModel { SelectedProduct = Products.CSharp, Date = DateTime.Now });
            //return View();
        }

        [DataAboutActions]
        [HttpPost]
        public IActionResult Register(RecordViewModel client)
        {
            bool isProductAndDateValid = ValidateHelpers.IsSelectedProductValid(client);

            if (!isProductAndDateValid)
            {
                ModelState.AddModelError("SelectedProduct", "Консультація з Основ не проводиться по понеділках");
            }

            if (ModelState.IsValid)
            {
                // service.AddRecord(new RecordModel 
                // { 
                //    Email = client.Email,  
                // });


                return View("Success", client);
            }


            return View(client);

        }
    }
}
