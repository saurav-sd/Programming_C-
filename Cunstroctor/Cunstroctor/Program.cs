using System;

namespace Cunstroctor
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var customer = new Customer();
            customer.Id = 1;
            customer.Name = "john";

            var order = new Order();
            customer.Orders.Add(order);

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}
