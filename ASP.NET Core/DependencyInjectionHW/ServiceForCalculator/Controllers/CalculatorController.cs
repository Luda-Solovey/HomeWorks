using Microsoft.AspNetCore.Mvc;
using ServiceForCalculator.Classes;
using ServiceForCalculator.Models;
using System.Diagnostics;

namespace ServiceForCalculator.Controllers
{
    public class CalculatorController : Controller
    {
        private readonly ICalcService _calcService;
        public CalculatorController(ICalcService calcService) 
        {
            _calcService = calcService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Multiplay(double? number1, double? number2)
        {
            if (number1 == null || number2 == null) { return BadRequest("Wrong input values"); }
            var result = _calcService.Multiplay(number1, number2);
            return View("Index", result);
        }

        public IActionResult Divide(double? number1, double? number2)
        {
            if (number1 == null || number2 == null) { return BadRequest("Wrong input values"); }
            var result = _calcService.Divide(number1, number2);
            return View("Index", result);
        }

        public IActionResult Plus(double? number1, double? number2)
        {
            if (number1 == null || number2 == null) { return BadRequest("Wrong input values"); }
            var result = (_calcService.Plus(number1, number2));
            return View("Index", result);
        }

        public IActionResult Subtract(double? number1, double? number2)
        {
            if (number1 == null || number2 == null) { return BadRequest("Wrong input values"); }
            var result = _calcService.Subtract(number1, number2);
            return View("Index", result);
        }
    }
}
