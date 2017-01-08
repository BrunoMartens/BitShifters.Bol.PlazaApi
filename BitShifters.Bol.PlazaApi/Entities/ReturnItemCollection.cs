using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class ReturnItemCollection
    {
        private ReturnItem[] _items;

        [XmlElement("Item")]
        public ReturnItem[] Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }
    }
}
