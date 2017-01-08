using BitShifters.Bol.PlazaApi.Config;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Repositories
{
    public class BaseRepository
    {
        protected PlazaApiConfig _config;
        protected Connector _connector;
        protected XmlRootAttribute _xmlRootAttribute;

        public BaseRepository(Connector connector, PlazaApiConfig config)
        {
            _connector = connector;
            _config = config; 
        }
    }
}
