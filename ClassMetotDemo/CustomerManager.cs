using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer1)
        {
            Console.WriteLine("Added Customer : " + customer1.Id);
            Console.WriteLine("Added Customer : " + customer1.Name);
            Console.WriteLine("Added Customer : " + customer1.Phone);
        }

        public void DeleteCustomer(Customer customer1)
        {
            Console.WriteLine("Deleted Customer : " + customer1.Id);
            Console.WriteLine("Deleted Customer : " + customer1.Name);
            Console.WriteLine("Deleted Customer : " + customer1.Phone);
        }

        public void ListCustomer(Customer customer1)
        {
            Console.WriteLine("Customer : " + customer1.Id);
            Console.WriteLine("Customer : " + customer1.Name);
            Console.WriteLine("Customer : " + customer1.Phone);
        }

        


    }
}
