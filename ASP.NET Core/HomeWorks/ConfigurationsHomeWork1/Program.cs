using ConfigurationsHomeWork1.ConfogurationModel;

namespace ConfigurationsHomeWork1
{
    //Завдання 1
    //Створити MVC додатків з одним поданням.Подання має відображати повідомлення, яке знаходиться у файлі конфігурації.
    //Зробіть так, щоб програма оновлювала повідомлення в поданні, якщо значення змінювалося в конфігураційному файлі.
    //Для оновлення даних у поданні програму не потрібно перевантажувати.

    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            //зв'язую секції конфігураційного класу з властивостями класу
            builder.Services.Configure<ConnectionModel>(builder.Configuration.GetSection("connection"));

            var app = builder.Build();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
