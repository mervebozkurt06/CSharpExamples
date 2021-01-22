using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Merve";
            customer1.Phone = "123456789";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Tugba";
            customer2.Phone = "123456965";


            Customer[] customers = new Customer[] { customer1, customer2 };


            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.DeleteCustomer(customer1);
            customerManager.ListCustomer(customer1);

            
        }
    }
}
