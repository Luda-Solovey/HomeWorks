using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.Extensions.Options;

namespace _12_AutentificationAvtorization
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
                options =>
                {
                    options.LoginPath = "/registre/signin";
                });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            // Додавання у пайплайн обробки запиту middleware автентифікації та авторизації
            // На цьому етапі буде виконана авторизація за вказанними схемами (в нашому випадку - Cookies)

            // При аутентифікації, додаток перевірить наявність Cookie автентифікації, 
            // спробує видобути з нього дані про користувача та розмістити їх у спеціальний об'єкт 
            // у контексті обробки запиту. (HttpContext.User)
            app.UseAuthentication();

            // На етапі авторизації додаток перевірить, чи є у користувача доступ до ресурсу, який запитується
            // Наприклад, якщо неавтентифікований користувач звернеться до методу дії, декорованному 
            // атрибутом Authorize, запит не пройде авторизацію та додаток переспрямує кристувача на сторінку для логіну
            app.UseAuthorization();//

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
