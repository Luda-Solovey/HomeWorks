namespace _08FormsAndValidation.Infrastructure
{
    public static class ValidateHelper
    {
        public static bool ValidateDate(DateTime registrationDate)
        {
            if (registrationDate < DateTime.Today || 
                registrationDate.DayOfWeek == DayOfWeek.Saturday ||
                registrationDate.DayOfWeek == DayOfWeek.Sunday)
            {
                return false;
            }
            return true;
                
        }
    }
}
