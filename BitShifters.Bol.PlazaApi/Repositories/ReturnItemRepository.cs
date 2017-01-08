using System;
using System.Collections.Generic;
using System.Text;
using BitShifters.Bol.PlazaApi.Config;
using System.Xml.Serialization;
using BitShifters.Bol.PlazaApi.Entities;
using System.Net.Http;
using System.Threading.Tasks;
using BitShifters.Bol.PlazaApi.Messages;
using BitShifters.Bol.PlazaApi.Helpers;

namespace BitShifters.Bol.PlazaApi.Repositories
{
    public class ReturnItemRepository : BaseRepository
    {
        public ReturnItemRepository(Connector connector, PlazaApiConfig config) : base(connector, config)
        {
            _xmlRootAttribute = new XmlRootAttribute("ReturnItems")
            {
                Namespace = _config.Namespace
            };
        }

        public async Task<ReturnItemCollection> GetReturnItemsAsync()
        {
            var url = _config.ReturnItemsUrl + "/unhandled";

            return await _connector.GetDataAsync<ReturnItemCollection>(HttpMethod.Get, url, _xmlRootAttribute);
        }

        public async Task<ProcessStatus> UpdateReturnItemStatusAsync(int returnNumber, ReturnItemStatusUpdate returnItemStatusUpdate)
        {
            var content = BolXmlSerializer.Serialize(returnItemStatusUpdate, _config.Namespace);
            var url = $"{_config.ReturnItemsUrl}/{returnNumber}/handle";
            return await _connector.GetDataAsync<ProcessStatus>(HttpMethod.Put, url, new XmlRootAttribute("ProcessStatus") { Namespace = _config.Namespace }, content);
        }
    }
}
