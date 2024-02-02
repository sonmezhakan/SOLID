using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_NotBad
{
    public interface IEmailSender
    {
        void EmailSender(string email,string body);
    }
}
