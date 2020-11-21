using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace Blog.Service
{
    public class Email
    {
        public void SendEmail(string userEmail, string username)
        {
            MailMessage message = new MailMessage
            {
                IsBodyHtml = true,
                From = new MailAddress("bloghost@myblog.com", "Bloghost")
            };
            message.To.Add(userEmail);
            message.Subject = "Сообщение о регистрации";
            message.Body =  $"<div>Привет, {username}! Спасибо за регистрацию на нашем сайте!</div>";

            using (System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.gmail.com"))
            {
                client.Credentials = new NetworkCredential("newsapp.app@gmail.com", "NewsApp1211");
                client.Port = 587;
                client.EnableSsl = true;

                client.Send(message);
            }
        }
    }
}
