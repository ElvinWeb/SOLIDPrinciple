using SRP.Models;

namespace SRP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Elvin";
            customer1.Surname = "Sarkarov";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Elcin";
            customer2.Surname = "Salmanov";

            CustomerService customerService = new CustomerService();
            customerService.AddCustomer(customer1);
            customerService.AddCustomer(customer2);

            EmailService emailService = new EmailService();
            emailService.SendEmail();


            foreach (var customer in EmployeeDataBase.CustomerList)
            {
                Console.WriteLine(customer);
            }
            Console.WriteLine("<================>");

            Console.WriteLine(customerService.FindCustomer(1));




        }
    }
}