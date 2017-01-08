using BitShifters.Bol.PlazaApi.Config;
using BitShifters.Bol.PlazaApi.Entities;
using BitShifters.Bol.PlazaApi.Enum;
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
    public class ShipmentRepository: BaseRepository
    {

        public ShipmentRepository(Connector connector, PlazaApiConfig config): base(connector,config)
        {
            _xmlRootAttribute = new XmlRootAttribute("Shipments")
            {
                Namespace = _config.Namespace

            };
        }

        public async Task<ShipmentCollection> GetShipmentsAsync(int page=1)
        {
            return await _connector.GetDataAsync<ShipmentCollection>(HttpMethod.Get, GetUrl(page), _xmlRootAttribute);
        }

        public async Task<ShipmentCollection> GetShipmentsByFulfilmentMethodAsync(FulfilmentMethod fulfilmentMethod, int page = 1)
        {
            return await _connector.GetDataAsync<ShipmentCollection>(HttpMethod.Get, GetUrl(page, fulfilmentMethod), _xmlRootAttribute);
        }

        public async Task<ProcessStatus> CreateShipmentAsync(ShipmentRequest shipmentRequest)
        {
            var content = BolXmlSerializer.Serialize<ShipmentRequest>(shipmentRequest, _config.Namespace);
            return await _connector.GetDataAsync<ProcessStatus>(HttpMethod.Post, _config.ShipmentsUrl, new XmlRootAttribute("ProcessStatus") { Namespace = _config.Namespace }, content);
        }

        public async Task<ProcessStatus> ChangeTransportAsync(int transportId, ChangeTransportRequest changeTransportRequest)
        {
            var url = $"{_config.TransportsUrl}/{transportId}";
            var content = BolXmlSerializer.Serialize<ChangeTransportRequest>(changeTransportRequest, _config.Namespace);
            return await _connector.GetDataAsync<ProcessStatus>(HttpMethod.Post, url, new XmlRootAttribute("ProcessStatus") { Namespace = _config.Namespace }, content);
        }



        private string GetUrl(int page, FulfilmentMethod? fulfilmentMethod = null)
        {
            var url = _config.ShipmentsUrl;

            url += $"?page={page}";

            if (fulfilmentMethod.HasValue)
            {
                url += $"&fulfilmentmethod={fulfilmentMethod.ToString().ToLower()}";
            }
            return url;
        }
    }
}