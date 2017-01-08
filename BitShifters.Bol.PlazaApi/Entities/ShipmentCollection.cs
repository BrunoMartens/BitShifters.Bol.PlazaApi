using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class ShipmentCollection
    {
        private Shipment[] _shipments;

        [XmlElement("Shipment")]
        public Shipment[] Shipments
        {
            get
            {
                return _shipments;
            }
            set
            {
                _shipments = value;
            }
        }
    }
}
