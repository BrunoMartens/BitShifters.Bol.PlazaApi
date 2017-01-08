using System;
using System.Collections.Generic;
using System.Text;
using BitShifters.Bol.PlazaApi.Config;
using System.Xml.Serialization;
using System.Threading.Tasks;
using BitShifters.Bol.PlazaApi.Entities;
using System.Net.Http;

namespace BitShifters.Bol.PlazaApi.Repositories
{
    public class ShippingLabelRepository : BaseRepository
    {
        public ShippingLabelRepository(Connector connector, PlazaApiConfig config) : base(connector, config)
        {
            _xmlRootAttribute = new XmlRootAttribute("PurchasableShippingLabels")
            {
                Namespace = _config.Namespace
            };
        }

        public async Task<PurchasableShippingLabelCollection> GetShippingLabelsAsync(int orderItemId)
        {
            var url = _config.ShippingLabelsUrl;

            url += $"?orderItemId={orderItemId}";

            return await _connector.GetDataAsync<PurchasableShippingLabelCollection>(HttpMethod.Get, url, _xmlRootAttribute);
        }

        //TODO:: Create Binary Get
        public async Task<ProcessStatus> GetShippingLabelAsync(int transportId, int shippingLabelId)
        {
            var url = _config.TransportsUrl;

            url += $"/{transportId}/shipping-label/{shippingLabelId}";

            return await _connector.GetDataAsync<ProcessStatus>(HttpMethod.Get, url, new XmlRootAttribute("ProcessStatus") { Namespace = _config.Namespace });
        }


    }
}
