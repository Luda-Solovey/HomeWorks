using DependencyInjHW.Services;

namespace DependencyInjHW.Classes
{
    public class DaysOfWeekService : ISend
    {
        public string[] Send() => ["Monday", "Thuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

    }
}
