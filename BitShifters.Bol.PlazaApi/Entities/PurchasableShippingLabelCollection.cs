using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class PurchasableShippingLabelCollection
    {
        private PurchasableShippingLabel[] _label;

        [XmlElement("Label")]
        public PurchasableShippingLabel[] Label
        {
            get
            {
                return _label;
            }
            set
            {
                _label = value;
            }
        }
    }
}
