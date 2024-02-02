namespace ISP_NotBad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eagle eagle = new Eagle();
            eagle.Fly();
            eagle.Walk();

            Penguin penguin = new Penguin();
            penguin.Walk();
        }
    }
}
