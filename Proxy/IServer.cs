namespace Proxy
{
    /// <summary>
    /// The Subject interface which both the real subject and proxy will need to implement.
    /// </summary>
    public interface IServer
    {
        /// <summary>
        /// Take order.
        /// </summary>
        /// <param name="order"> Order. </param>
        void TakeOrder(string order);

        /// <summary>
        /// Delivery order.
        /// </summary>
        string DeliverOrder();

        /// <summary>
        /// Process payment.
        /// </summary>
        /// <param name="payment"> Payment. </param>
        void ProcessPayment(string payment);
    }
}