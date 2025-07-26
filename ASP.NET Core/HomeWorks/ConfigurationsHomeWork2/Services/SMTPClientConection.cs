using ConfigurationsHomeWork2.Models;
using System.Net;
using System.Net.Mail;

namespace ConfigurationsHomeWork2.Services
{
    public static class SMTPClientConection
    {
        public static IServiceCollection AddSmtpClient (this IServiceCollection services, WebApplicationBuilder builder)
        {
            //зв'язую секції конфігураційного класу з властивостями класу
            var networkSettings = builder.Configuration.GetSection("SmtpSettings").Get<SmtpSettingsModel>() ??
                throw new ArgumentException("Configuration for SMTP Client has not been read");
            //  builder.Services.Configure<EmailSettingsModel>(builder.Configuration.GetSection("EmailSettings"));
            //  TODO Comine in one method - builder.Configuration.AddSmtpClient() 
            var credentials = new NetworkCredential(networkSettings.Credentials.SenderEmail, networkSettings.Credentials.Password);
            builder.Services.AddSingleton(services => new SmtpClient(networkSettings.SmtpServer)
            {
                Port = networkSettings.Port,
                Credentials = credentials,
                EnableSsl = networkSettings.EnableSsl,
                UseDefaultCredentials = false,
            });

            return services; // за згодою метод повинен повертати IServiceCollection для можливості використання ланцюжка викликів
        }
    }
}
