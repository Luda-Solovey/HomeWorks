using ConfigurationsHomeWork2.Controllers;
using ConfigurationsHomeWork2.Models;
using ConfigurationsHomeWork2.Services;
using System.Net;
using System.Net.Mail;

namespace ConfigurationsHomeWork2
{
    public class Program
    {
        //�������� 2
        //������� MVC �������, ���� ��������� �����, ��� ���� ���������� email �����������.
        //� ���� ������ ���� �������� � ���������, ����, �����������.
        //��� ���������� ����������� ������������� �� ������� ��������� ������.
        //���� �������� ������� ��������� �����������, ������������ ������ ����� ��������� �������.
        //��� ��� ���������� ���������� �� ������� ������� � ��������������� ����.
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.Configure<EmailSettingsModel>(builder.Configuration.GetSection("SmtpSettings"));
            //��'���� ������ ���������������� ����� � ������������� �����
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

            //������� ���������� SMTPClient � ��������� ���� SMTPClientConection
            builder.Services.AddSmtpClient(builder);// ��� �����? ��� ����� ������� ������� ���������� ��������� WebApplicationBuilder?

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
