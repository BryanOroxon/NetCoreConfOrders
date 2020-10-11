using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Data.Orders;
using Domain.Orders;

namespace NetCoreConfOrders.Framework.DataSources
{
    public class InMemoryOrdersSource : IOrdersSource 
    {
        public async Task<IReadOnlyList<Order>> GetAll()
        {
            await Task.Delay(1000);
            var result = new List<Order>();
            for (int i = 0; i < 10; i++)
            {
                result.Add(new Order
                {
                    OrderId = $"B00{i}",
                    DeliveryTime = DateTime.Now.ToShortDateString()
                });
            }
            return result;
        }
    }
}
