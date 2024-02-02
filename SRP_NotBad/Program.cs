namespace SRP_NotBad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerRepository customerRepository = new CustomerRepository();
            customerRepository.Create(new Customer
            {
                FirstName = "Test",
                LastName = "Test"
            });

        }
    }
}
