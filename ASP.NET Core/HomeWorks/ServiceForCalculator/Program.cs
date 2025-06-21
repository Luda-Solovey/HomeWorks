using ServiceForCalculator.Classes;

namespace ServiceForCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddServices();//підключаємо сервіси

            var app = builder.Build();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Calculator}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
