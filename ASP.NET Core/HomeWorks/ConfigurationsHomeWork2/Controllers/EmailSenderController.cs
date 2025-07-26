using ConfigurationsHomeWork2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Http;
using System.Net.Mail;

namespace ConfigurationsHomeWork2.Controllers
{
    public class EmailSenderController : Controller
    {
        private readonly SmtpClient smtpClient;
        private readonly ILogger<EmailSenderController> logger;

        public EmailSenderController(SmtpClient smtpClient, ILogger<EmailSenderController> logger)
        {
            this.smtpClient = smtpClient;
            this.logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SendEmail() 
        {
            return View(new EmailModel());
        }


        [HttpPost]
        public IActionResult SendEmail([FromForm] EmailModel myMessage)//чомусь текст повідомлення не прив'язується
        {
            try
            {
                smtpClient.Send(myMessage.Sender, myMessage.Recipient, myMessage.Theme, myMessage.Message);
            }
            catch (Exception ex)
            {
                logger.LogError("Error has been occured per sending mail with following message {0}", ex.Message);
            }
            

            //smtpClient.Send("evtuhovaludmila36@gmail.com", "lsolovey@ama.dp.ua", "tema", "body");

            //using (MailMessage mail = new MailMessage())
            //{
            //    mail.From = new MailAddress("evtuhovaludmila36@gmail.com");
            //    mail.To.Add("lsolovey@ama.dp.ua");
            //    mail.Subject = "Hello World";
            //    mail.Body = "<h1>Hello</h1>";
            //    mail.IsBodyHtml = true;
            //    //mail.Attachments.Add(new Attachment("C:\\file.zip"));

            //    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
            //    {
            //        smtp.Credentials = new NetworkCredential("evtuhovaludmila36@gmail.com", "blessednow2025");
            //        smtp.EnableSsl = true;
            //        smtp.Send(mail);
            //    }
            //}
            return View();
        }
    }
}
