using DependencyInjHW.Classes;
using DependencyInjHW.Services;
using Microsoft.AspNetCore.Mvc;

namespace DependencyInjHW.Controllers
{
    public class CalendarController : Controller
    {
        //private readonly ISend calendarData;
        public IActionResult ReturnDays([FromServices] DaysOfWeekService daysOfWeek) 
        {
            var result = daysOfWeek.Send();
            return View("Calendar", result);
        }

        public IActionResult ReturnMonthes([FromServices] MonthesService monthesOfYear) 
        { 
            var result = monthesOfYear.Send();
            return View("Calendar", result);
        }
    }
}
