using System.Collections.Generic;

namespace DesignPatterns.CommandPattern
{
    public class Broker
    {
        protected IList<IOrder> _orders;

        public Broker()
        {
            _orders = new List<IOrder>();
        }

        public void TakeOrder(IOrder order)
        {
            _orders.Add(order);
        }

        public void PlaceOrders()
        {
            foreach (var order in _orders)
            {
                order.Execute();
            }
            _orders.Clear();
        }
    }
}
