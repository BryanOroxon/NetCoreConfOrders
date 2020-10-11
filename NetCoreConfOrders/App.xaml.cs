using System;
using Data.Orders;
using NetCoreConfOrders.Framework.DataSources;
using NetCoreConfOrders.UI.Orders.ViewModels;
using NetCoreConfOrders.UI.Orders.Views;
using Prism;
using Prism.Ioc;
using Prism.Navigation;
using Prism.Unity;
using UsesCases.Orders;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NetCoreConfOrders
{
    public partial class App : PrismApplication
    { 
        public App(IPlatformInitializer plataformInitializer = null) : base(plataformInitializer) { }
        
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<OrdersListPage, OrdersListPageViewModel>();
            containerRegistry.Register<OrdersRepository>();
            containerRegistry.Register<IOrdersSource, InMemoryOrdersSource>();
            containerRegistry.Register<GetCurrentUserOrders>();

        }

        protected override void OnInitialized()
        {
            InitializeComponent();
            NavigationService.NavigateAsync("OrdersListPage");
        }

    }
    
}
