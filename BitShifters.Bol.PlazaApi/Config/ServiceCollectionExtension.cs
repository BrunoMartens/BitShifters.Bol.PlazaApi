using BitShifters.Bol.PlazaApi.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Config
{
    public static class ServiceCollectionExtension
    {
        public static void AddPlazaApi(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<Connector>();

            serviceCollection.AddTransient<OrderRepository>();
            serviceCollection.AddTransient<ReturnItemRepository>();
            serviceCollection.AddTransient<ShipmentRepository>();
            serviceCollection.AddTransient<ShippingLabelRepository>();
            serviceCollection.AddTransient<ProcessStatusRepository>();

            serviceCollection.AddTransient<PlazaApiClient>();
        }
    }
}
