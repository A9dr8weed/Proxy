using System;

namespace Proxy
{
    public static class Program
    {
        private static void Main()
        {
            IServer proxy = new ServerProxy();

            // Manage orders from a table.
            Console.WriteLine("What would you like to order? ");

            string order = Console.ReadLine();
            proxy.TakeOrder(order);

            Console.WriteLine($"Sure thing! Here's your {proxy.DeliverOrder()}.");
            Console.WriteLine("How would you like to pay?");

            string payment = Console.ReadLine();
            proxy.ProcessPayment(payment);
        }
    }
}