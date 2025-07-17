namespace ConfigurationsHomeWork2
{
    public class Program
    {
        //Завдання 2
        //Створіть MVC додаток, яким реалізуйте форму, яка буде відправляти email повідомлення.
        //У формі зробіть поля введення – одержувач, тема, повідомлення.
        //Для надсилання повідомлення зареєструйтесь на якомусь поштовому сервері.
        //Ваша програма повинна надсилати повідомлення, користуючись даними цього поштового сервера.
        //Дані для надсилання підключення до сервера винесіть у конфігураційний файл.
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
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
