namespace OCP_NotBad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmailSender emailSender = new EmailSender(new GmailEmailSender());//Gmail or Outlook
            emailSender.EmailSend("a@outlook.com", "Test");
        }
    }
}
