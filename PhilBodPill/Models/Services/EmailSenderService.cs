using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhilBodPill.Models
{
    public class EmailSenderService : IEmailSender
    {
        public IConfiguration Configuration { get; }

        public EmailSenderService(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(Configuration["SendGrid_API_Key"]);

            var msg = new SendGridMessage();

            msg.SetFrom("nethwebdev@gmail.com", "Philospher Body Pillow Team");

            msg.AddTo(new EmailAddress("jhwe92@gmail.com"));
            //msg.AddTo(new EmailAddress("nethwebdev@gmail.com"));
            msg.AddTo(new EmailAddress(email));

            msg.SetSubject(subject);
            
            msg.AddContent(MimeType.Html, $"<p>{htmlMessage}</p> <p>Thanks for registering your account with us! Now you'll be able to enjoy full quality sleep every night! ...With a purchase of one of our pillows that is. </p> <p>Do NOT reply to this email, bad things may happen.");
            var response = await client.SendEmailAsync(msg);
        }
    }
}
