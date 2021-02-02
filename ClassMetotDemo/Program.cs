namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.IdNumber = 1;
            customer1.FirstName = "İlkay";
            customer1.LastName = "AYDIN";
            customer1.City = "ANKARA";

            Customer customer2 = new Customer();
            customer2.IdNumber = 2;
            customer2.FirstName = "Batuhan";
            customer2.LastName = "ÖZYÖN";
            customer2.City = "ANKARA";

            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);

            Customer[] customers = new[] {customer1,customer2};

            foreach (Customer customer in customers)
            {
                System.Console.WriteLine(customer.IdNumber + " " + customer.FirstName + "  " + customer.LastName + " " + "/" + customer.City);
            }

            
            
        }
    }
}
