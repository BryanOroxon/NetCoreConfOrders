using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Orders;

namespace Data.Orders
{
    public interface IOrdersSource
    {
        Task<IReadOnlyList<Order>> GetAll();
    }
}
