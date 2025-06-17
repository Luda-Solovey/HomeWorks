using DependencyInjHW.Models;
using DependencyInjHW.Services;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace DependencyInjHW.Classes
{
    public class MonthesService : ISend
    {
        /// чи треба зробити цей клас статичним???
        public string[] Send() =>  [ "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" ];


        //тут не дорозбирали для чого така реалізація (цей метод)
        //public CalendarModel GetNames()
        //{
        //    return new CalendarModel
        //    {
        //        DayOfWeeks = ["Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"],
        //        Monthes = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"]
        //    };
        //}
    }
}
