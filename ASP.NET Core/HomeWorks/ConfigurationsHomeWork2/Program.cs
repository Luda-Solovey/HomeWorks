using ConfigurationsHomeWork2.Controllers;
using ConfigurationsHomeWork2.Models;
using ConfigurationsHomeWork2.Services;
using System.Net;
using System.Net.Mail;

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

            builder.Services.Configure<EmailSettingsModel>(builder.Configuration.GetSection("SmtpSettings"));
            //зв'язую секції конфігураційного класу з властивостями класу
            //var networkSettings = builder.Configuration.GetSection("SmtpSettings").Get<SmtpSettingsModel>() ?? 
            //    throw new ArgumentException("Configuration for SMTP Client has not been read");
            ////  builder.Services.Configure<EmailSettingsModel>(builder.Configuration.GetSection("EmailSettings"));
            ////  TODO Comine in one method - builder.Configuration.AddSmtpClient() 
            //var credentials = new NetworkCredential(networkSettings.Credentials.SenderEmail, networkSettings.Credentials.Password);
            //builder.Services.AddSingleton(services => new SmtpClient(networkSettings.SmtpServer)
            //{
            //    Port = networkSettings.Port,
            //    Credentials = credentials,
            //    EnableSsl = networkSettings.EnableSsl,
            //    UseDefaultCredentials = false,
            //});

            //винесла підключення SMTPClient в статичний клас SMTPClientConection
            builder.Services.AddSmtpClient(builder);// так можна? щоб метод приймав вхідним параметром екземпляр WebApplicationBuilder?

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
