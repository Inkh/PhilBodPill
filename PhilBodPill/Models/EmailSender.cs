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
    public class EmailSender : IEmailSender
    {
        public IConfiguration Configuration { get; }

        public EmailSender(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var client = new SendGridClient(Configuration["SendGrid_API_Key"]);

            var msg = new SendGridMessage();

            msg.SetFrom("admin@philbodpill.com", "Philospher Body Pillow Team");

            msg.AddTo(new EmailAddress("jhwe92@gmail.com"));

            var response = await client.SendEmailAsync(msg);
            msg.SetSubject("Testing the SendGrid C# Library");

            msg.AddContent(MimeType.Text, "Hello World plain text!");
            msg.AddContent(MimeType.Html, "<p>Hello World!</p>");
        }
    }
}
