using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class OrderCollection
    {
        private Order[] _orders;

        [XmlElement("Order")]
        public Order[] Orders
        {
            get
            {
                return this._orders;
            }
            set
            {
                this._orders = value;
            }
        }
    }
}
