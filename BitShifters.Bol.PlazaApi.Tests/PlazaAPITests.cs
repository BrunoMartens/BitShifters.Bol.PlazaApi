using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;
using System.Net.Http;
using BitShifters.Bol.PlazaApi;
using BitShifters.Bol.PlazaApi.Config;
using BitShifters.Bol.PlazaApi.Repositories;
using BitShifters.Bol.PlazaApi.Messages;
using BitShifters.Bol.PlazaApi.Enum;
using BitShifters.Bol.PlazaApi.Entities;

namespace GeldBeugel.Data.Tests
{
    [TestClass]
    public class PlazaApiTests
    {
        private PlazaApiClient _plazaApi;

        public PlazaApiTests()
        {
            var plazaApiConfig = new PlazaApiConfig
            {
                RootEndPoint = "https://test-plazaapi.bol.com",
                Namespace = "https://plazaapi.bol.com/services/xsd/v2/plazaapi.xsd",
                OrdersUrl = "/services/rest/orders/v2",
                OrderItemsUrl = "/services/rest/order-items/v2",
                ShipmentsUrl = "/services/rest/shipments/v2",
                ShippingLabelsUrl = "/services/rest/purchasable-shipping-labels/v2",
                TransportsUrl = "/services/rest/transports/v2",
                ReturnItemsUrl = "/services/rest/return-items/v2",
                ProcessStatusUrl = "/services/rest/process-status/v2",
                PublicKey = "[YOUR PUBLIC KEY]",
                PrivateKey = "[YOUR PRIVATE KEY]"
            };


            var connector = new Connector(plazaApiConfig);

            var orderRepository = new OrderRepository(connector, plazaApiConfig);
            var shipmentRepository = new ShipmentRepository(connector, plazaApiConfig);
            var shippingLabelRepository = new ShippingLabelRepository(connector, plazaApiConfig);
            var returnItemRepository = new ReturnItemRepository(connector, plazaApiConfig);
            var processStatusRepository = new ProcessStatusRepository(connector, plazaApiConfig);

            _plazaApi = new PlazaApiClient(orderRepository, 
                                            shipmentRepository,
                                            shippingLabelRepository,
                                            returnItemRepository,
                                            processStatusRepository);
        }

        [TestMethod]
        public async Task ShouldReturnItsOrdersAsync()
        {
            var expectedOrders = 2;

            var orderCollection = await _plazaApi.OrderRepository.GetOrdersAsync();
            Assert.IsInstanceOfType(orderCollection, typeof(OrderCollection));
            Assert.AreEqual(expectedOrders, orderCollection.Orders.Length);
        }

        [TestMethod]
        public async Task ShouldCancelItsOrderItemAsync()
        {
            var processStatus = await _plazaApi.OrderRepository.CancelOrderItemAsync(123, new Cancellation {
                DateTime = DateTime.Now,
                ReasonCode = ReasonCode.ORDERED_TWICE
            });
        }

        [TestMethod]
        public async Task ShouldReturnItsShipmentsAsync()
        {
            var shipmentCollection = await _plazaApi.ShipmentRepository.GetShipmentsAsync();
        }

        [TestMethod]
        public async Task ShouldReturnItsShipmentsByFulfilmentMethodAsync()
        {
            var shipmentCollection = await _plazaApi.ShipmentRepository.GetShipmentsByFulfilmentMethodAsync(FulfilmentMethod.FBB);
        }

        [TestMethod]
        public async Task ShouldCreateItsShipmentAsync()
        {
            var processStatus = await _plazaApi.ShipmentRepository.CreateShipmentAsync(new ShipmentRequest
            {
                DateTime = DateTime.Now,
                ExpectedDeliveryDate = DateTime.Now.AddDays(3),
                OrderItemId = 123,
                ShipmentReference = "TestReference"  
            });
        }

        [TestMethod]
        public async Task ShouldReturnItsReturnItemsAsync()
        {
            var returnItemCollection = await _plazaApi.ReturnItemRepository.GetReturnItemsAsync();
        }

        [TestMethod]
        public async Task ShouldHandleItsReturnItemAsync()
        {
            var processStatus = await _plazaApi.ReturnItemRepository.UpdateReturnItemStatusAsync(0, new ReturnItemStatusUpdate {
                QuantityReturned = 1,
                StatusReason = StatusReason.PRODUCT_RECEIVED
            });
        }

        [TestMethod]
        public async Task ShouldReturnItsShippingLabelsAsync()
        {
            var shippingLabelCollection = await _plazaApi.ShippingLabelRepository.GetShippingLabelsAsync(0);
        }

        [TestMethod]
        public async Task ShouldReturnItsShippingLabelAsync()
        {
            var processStatus = await _plazaApi.ShippingLabelRepository.GetShippingLabelAsync(72862288, 683);
        }

        [TestMethod]
        public async Task ShouldReturnItsProcessStatusAsync()
        {
            var processStatus = await _plazaApi.ProcessStatusRepository.GetProcessStatusAsync(456);
        }

    }
}
