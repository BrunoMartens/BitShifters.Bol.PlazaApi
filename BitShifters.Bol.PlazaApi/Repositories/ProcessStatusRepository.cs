using System;
using System.Collections.Generic;
using System.Text;
using BitShifters.Bol.PlazaApi.Config;
using System.Threading.Tasks;
using BitShifters.Bol.PlazaApi.Entities;
using System.Net.Http;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Repositories
{
    public class ProcessStatusRepository : BaseRepository
    {
        public ProcessStatusRepository(Connector connector, PlazaApiConfig config) : base(connector, config)
        {
            _xmlRootAttribute = new XmlRootAttribute("ProcessStatus")
            {
                Namespace = _config.Namespace
            };
        }

        public async Task<ProcessStatus> GetProcessStatusAsync(int processStatusId)
        {
            var url = _config.ProcessStatusUrl + $"/{processStatusId}";

            return await _connector.GetDataAsync<ProcessStatus>(HttpMethod.Get, url, _xmlRootAttribute);
        }
    }
}
