using BitShifters.Bol.PlazaApi.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class ProcessStatus
    {
        private long _id;

        private long _sellerId;

        private string _entityId;

        private string _eventType;

        private string _description;

        private Status _status;

        private string _errorMessage;

        private DateTime _createTimestamp;

        private Link[] _links;

        
        [XmlElement("id")]
        public long Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        [XmlElement("sellerId")]
        public long SellerId
        {
            get
            {
                return _sellerId;
            }
            set
            {
                _sellerId = value;
            }
        }

        [XmlElement("entityId")]
        public string EntityId
        {
            get
            {
                return _entityId;
            }
            set
            {
                _entityId = value;
            }
        }

        [XmlElement("eventType")]
        public string EventType
        {
            get
            {
                return _eventType;
            }
            set
            {
                _eventType = value;
            }
        }

        [XmlElement("description")]
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }

        [XmlElement("status")]
        public Status Status
        {
            get
            {
                return _status;
            }
            set
            {
                _status = value;
            }
        }

        [XmlElement("errorMessage")]
        public string ErrorMessage
        {
            get
            {
                return _errorMessage;
            }
            set
            {
                _errorMessage = value;
            }
        }

        [XmlElement("createTimestamp")]
        public DateTime CreateTimestamp
        {
            get
            {
                return _createTimestamp;
            }
            set
            {
                _createTimestamp = value;
            }
        }

        public Link[] Links
        {
            get
            {
                return _links;
            }
            set
            {
                _links = value;
            }
        }
    }
}
