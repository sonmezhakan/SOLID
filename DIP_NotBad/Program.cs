namespace DIP_NotBad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger logger = new Logger(new DatabaseLogger());
            logger.Log();
        }
    }
}
