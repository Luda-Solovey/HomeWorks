using BindingModel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BindingModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(OrderModel order)
        {
            return View(order);
        }
        [HttpGet]
        public IActionResult MakeOrder() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult MakeOrder(OrderModel order)
        {
            //???дебаг не пишеться
            Debug.WriteLine("The firrst value is {0}", order.First);
            Debug.WriteLine("The second value is {0}", order.Second);
            Debug.WriteLine("Count value is {0}", order.Count);
            return View("Thanks", order);
        }

    }
}
