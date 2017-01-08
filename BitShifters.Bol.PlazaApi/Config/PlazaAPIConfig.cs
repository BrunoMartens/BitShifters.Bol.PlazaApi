using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Config
{
    
    public class PlazaApiConfig
    {
        public string RootEndPoint { get; set; }

        public string OrdersUrl { get; set; }

        public string OrderItemsUrl { get; set; }

        public string ShippingLabelsUrl { get; set; }

        public string ShipmentsUrl { get; set; }

        public string TransportsUrl { get; set; }

        public string ReturnItemsUrl { get; set; }

        public string ProcessStatusUrl { get; set; }

        public string PublicKey { get; set; }

        public string PrivateKey { get; set; }

        public string Namespace { get; set; }

    }
}
