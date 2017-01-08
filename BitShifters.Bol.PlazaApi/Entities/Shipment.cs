using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class Shipment
    {
        private long _shipmentId;

        private bool _shipmentIdSpecified;

        private System.DateTime _shipmentDate;

        private System.DateTime _expectedDeliveryDate;

        private string _shipmentReference;

        private ShipmentItem[] _shipmentItems;

        private Transport _transport;

        private CustomerDetails _customerDetails;

        
        public long ShipmentId
        {
            get
            {
                return _shipmentId;
            }
            set
            {
                _shipmentId = value;
            }
        }

        public bool ShipmentIdSpecified
        {
            get
            {
                return _shipmentIdSpecified;
            }
            set
            {
                _shipmentIdSpecified = value;
            }
        }

        
        public System.DateTime ShipmentDate
        {
            get
            {
                return _shipmentDate;
            }
            set
            {
                _shipmentDate = value;
            }
        }

        
        public System.DateTime ExpectedDeliveryDate
        {
            get
            {
                return _expectedDeliveryDate;
            }
            set
            {
                _expectedDeliveryDate = value;
            }
        }

        
        public string ShipmentReference
        {
            get
            {
                return _shipmentReference;
            }
            set
            {
                _shipmentReference = value;
            }
        }

        
        public ShipmentItem[] ShipmentItems
        {
            get
            {
                return _shipmentItems;
            }
            set
            {
                _shipmentItems = value;
            }
        }

        
        public Transport Transport
        {
            get
            {
                return _transport;
            }
            set
            {
                _transport = value;
            }
        }

        
        public CustomerDetails CustomerDetails
        {
            get
            {
                return _customerDetails;
            }
            set
            {
                _customerDetails = value;
            }
        }
    }
}
