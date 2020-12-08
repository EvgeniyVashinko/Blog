using Microsoft.Extensions.Configuration;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Blog.Service
{
    //public class Email
    //{
    //    public void SendEmail(string userEmail, string username)
    //    {
    //        MailMessage message = new MailMessage
    //        {
    //            IsBodyHtml = true,
    //            From = new MailAddress("bloghost@myblog.com", "Bloghost")
    //        };
    //        message.To.Add(userEmail);
    //        message.Subject = "Сообщение о регистрации";
    //        message.Body =  $"<div>Привет, {username}! Спасибо за регистрацию на нашем сайте!</div>";

    //        using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com"))
    //        {
    //            client.Credentials = new NetworkCredential(Config.Email, Config.Password);
    //            client.Port = 587;
    //            client.EnableSsl = true;

    //            client.Send(message);
    //        }
    //    }
    //}

    public class Email
    {
        public async Task SendEmail(string email, string username)
        {
            using var emailMessage = new MailMessage
            {
                From = (new MailAddress(Config.Email, "Bloghost")),
                Body = $"<div>Привет, {username}! Спасибо за регистрацию на нашем сайте!</div>",
                Subject = "Сообщение о регистрации",
                IsBodyHtml = true
            };
            emailMessage.To.Add(new MailAddress(email, email));

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.Host = "smtp.gmail.com";
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = new System.Net.NetworkCredential(Config.Email, Config.Password);
            smtp.EnableSsl = true;
            smtp.Send(emailMessage);
        }
    }
}
