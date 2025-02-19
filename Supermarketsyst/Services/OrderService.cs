using Supermarketsyst.Models;

namespace Supermarketsyst.Services
{
    public class OrderService
    {
        private List<Order> _orders = new List<Order>();
        private int _orderCounter = 1;

        public Order CreateOrder()
        {
            Order newOrder = new Order(_orderCounter++);
            _orders.Add(newOrder);
            return newOrder;
        }

        public void ViewOrders()
        {
            foreach (var order in _orders)
            {
                Console.WriteLine($"Order ID: {order.Id}, Total: {order.TotalAmount}");
            }
        }
    }

}
