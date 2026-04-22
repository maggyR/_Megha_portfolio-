using System.Net;
using System.Net.Mail;
using Microsoft.AspNetCore.Mvc;
using MyProfile.Models;

namespace MyProfile.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendMessage(string name, string email, string subject, string message)
        {
            try
            {
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                var smtp = new SmtpClient("smtp.mail.yahoo.com", 587)
                {
                    EnableSsl = true,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("mghptl@yahoo.com", "CenSait@1115"),
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    Timeout = 20000
                };

                var mail = new MailMessage
                {
                    From = new MailAddress("mghptl@yahoo.com"),
                    Subject = subject,
                    Body = $"Name: {name}\nEmail: {email}\nMessage: {message}"
                };

                mail.To.Add("your@yahoo.com");

                smtp.Send(mail);

                return Content("Message sent successfully!");
            }
            catch (Exception ex)
            {
                return Content(ex.ToString());
            }
        }
    }
}
