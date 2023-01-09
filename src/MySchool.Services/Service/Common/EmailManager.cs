using MailKit.Net.Smtp;
using Microsoft.Extensions.Configuration;
using MimeKit;
using MimeKit.Text;
using MySchool.Services.Attributes;
using MySchool.Services.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySchool.Services.Service.Common
{
    public class EmailManager : IEmailManager
    {
        private readonly IConfiguration _config;
        public EmailManager(IConfiguration configuration)
        {
            _config = configuration.GetSection("EmailConnection");
        }
        public async Task<bool> SendCode(string email, int code)
        {
            var mail = new MimeMessage();
            mail.From.Add(MailboxAddress.Parse(_config["Email"]));
            mail.To.Add(MailboxAddress.Parse(email));
            mail.Subject = "Confimation Code for my-school.uz";
            mail.Body = new TextPart(TextFormat.Html) { Text = code.ToString() };

            var smtp = new SmtpClient();
            await smtp.ConnectAsync(_config["Host"], int.Parse(_config["Port"]), MailKit.Security.SecureSocketOptions.StartTls);
            await smtp.AuthenticateAsync(_config["Email"], _config["Password"]);
            await smtp.SendAsync(mail);
            await smtp.DisconnectAsync(true);
            return  true;
        }
    }
}
