using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace _08FormsAndValidation.Infrastructure
{
    public class DataAboutActions : ActionFilterAttribute 
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            DateTime currentTime = DateTime.Now;

            string message = $"Викликаний метод {context.ActionDescriptor.DisplayName}, час виклику - {currentTime}";

            StreamWriter writer = new StreamWriter("App_Data/logs.txt", true);
            writer.WriteLine(message);
            writer.Close();

        }
    }
}
