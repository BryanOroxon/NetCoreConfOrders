using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Orders;
using Domain.Orders;

namespace UsesCases.Orders
{
    public class GetCurrentUserOrders
    {
        private readonly OrdersRepository _ordersRepository;

        public GetCurrentUserOrders(OrdersRepository ordersRepository)
        {
            _ordersRepository = ordersRepository;
        }

        public Task<IReadOnlyList<Order>> Invoke()
        {
            return _ordersRepository.GetOrdersAsync();
        }
    }
}
