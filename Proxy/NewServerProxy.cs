using System;

namespace Proxy
{
    /// <summary>
    /// The Proxy class, which can substitute for the Real Subject.
    /// </summary>
    public class NewServerProxy : IServer
    {
        /// <summary>
        /// Order.
        /// </summary>
        private string Order;

        /// <summary>
        /// Reference to a real object, controls access to it, can manage its creation and deletion.
        /// </summary>
        private readonly Server _server = new Server();

        public void TakeOrder(string order)
        {
            Console.WriteLine($"New trainee server takes order for {order}.");
            Order = order;
        }

        public string DeliverOrder()
        {
            return Order;
        }

        /// <summary>
        /// Payment process which called to server object.
        /// </summary>
        /// <param name="payment"></param>
        public void ProcessPayment(string payment)
        {
            Console.WriteLine("New trainee cannot process payments yet!");
            _server.ProcessPayment(payment);
        }
    }
}
