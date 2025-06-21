namespace ServiceForCalculator.Classes
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<ICalcService, CalcService>();
            return services;
        }
    }
}
