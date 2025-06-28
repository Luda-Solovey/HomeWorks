using _08FormsAndValidation.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace _08FormsAndValidation.Infrastructure
{
    public static class ValidateHelpers
    {
        public static bool IsSelectedProductValid(RecordViewModel product)
        {
            if (product.SelectedProduct == Products.Основи && product.Date.DayOfWeek == DayOfWeek.Monday)
            {
                return false;
            }
            return true;
        }
    }
}
