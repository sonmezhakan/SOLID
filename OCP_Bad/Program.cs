namespace OCP_Bad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GmailEmailSender gmailSender = new GmailEmailSender();
            gmailSender.EmailSender("a@gmail.com", "Test");

            OutlookEmailSender outlookSender = new OutlookEmailSender();
            outlookSender.EmailSender("a@outlook.com", "Test");
        }
    }
}
