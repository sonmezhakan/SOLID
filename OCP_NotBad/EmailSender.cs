using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_NotBad
{
    public class EmailSender
    {
        private readonly IEmailSender _emailSender;

        public EmailSender(IEmailSender emailSender)
        {
            _emailSender = emailSender;
        }

        public void EmailSend(string email, string body)
        {
            _emailSender.EmailSender(email, body);
        }
    }
}
