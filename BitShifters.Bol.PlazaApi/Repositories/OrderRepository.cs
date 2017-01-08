using BitShifters.Bol.PlazaApi.Config;
using BitShifters.Bol.PlazaApi.Entities;
using BitShifters.Bol.PlazaApi.Helpers;
using BitShifters.Bol.PlazaApi.Messages;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Repositories
{
    public class OrderRepository: BaseRepository
    {

        public OrderRepository(Connector connector, PlazaApiConfig config):base(connector, config)
        {
            _xmlRootAttribute = new XmlRootAttribute("Orders")
            {
                Namespace = _config.Namespace
            };
        }

        public async Task<OrderCollection> GetOrdersAsync()
        {
            return await _connector.GetDataAsync<OrderCollection>(HttpMethod.Get, _config.OrdersUrl, _xmlRootAttribute);   
        }

        public async Task<ProcessStatus> CancelOrderItemAsync(int orderItemId, Cancellation cancellation)
        {
            var content = BolXmlSerializer.Serialize<Cancellation>(cancellation, _config.Namespace);

            var url = $"{_config.OrderItemsUrl}/{orderItemId}/cancellation";

            return await _connector.GetDataAsync<ProcessStatus>(HttpMethod.Put, url, new XmlRootAttribute("ProcessStatus") { Namespace = _config.Namespace}, content);
        }
    }
}
