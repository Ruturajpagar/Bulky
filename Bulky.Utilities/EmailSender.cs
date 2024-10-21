using Microsoft.AspNetCore.Identity.UI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Utilities
{
    public class EmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // can use emailjs or the logic to send email here
            return Task.CompletedTask;
        }
    }
}
