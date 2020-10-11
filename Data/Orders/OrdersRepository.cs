using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Orders;

namespace Data.Orders
{
    public class OrdersRepository
    {
        private readonly IOrdersSource _ordersSource;

        public OrdersRepository(IOrdersSource ordersSource)
        {
            _ordersSource = ordersSource;
        }

        public async Task<IReadOnlyList<Order>> GetOrdersAsync()
        {
            return await _ordersSource.GetAll();
        }
    }
}
