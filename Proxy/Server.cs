using System;

namespace Proxy
{
    /// <summary>
    /// The real subject class which the Proxy can stand in for.
    /// </summary>
    public class Server : IServer
    {
        /// <summary>
        /// Order.
        /// </summary>
        private string Order;

        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for " + order + ".");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        public void ProcessPayment(string payment)
        {
            Console.WriteLine($"Payment for order ({payment}) processed.");
        }
    }
}