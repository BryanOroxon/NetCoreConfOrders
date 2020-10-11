using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Domain.Orders;
using UsesCases.Orders;

namespace NetCoreConfOrders.UI.Orders.ViewModels
{
    public class OrdersListPageViewModel
    {
        public ObservableCollection<Order> Orders { get; set; }
        private readonly GetCurrentUserOrders _getCurrentUserOrders;
        public OrdersListPageViewModel(GetCurrentUserOrders getCurrentUserOrders)
        {
            _getCurrentUserOrders = getCurrentUserOrders;
            Orders = new ObservableCollection<Order>();
            LoadOrders();
        }

        private async Task LoadOrders()
        {
            var results = await _getCurrentUserOrders.Invoke();
            foreach(var item in results)
            {
                Orders.Add(item);
            }
        }
    }
}
