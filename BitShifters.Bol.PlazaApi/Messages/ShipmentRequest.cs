using BitShifters.Bol.PlazaApi.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Messages
{
    public class ShipmentRequest
    {
        private long _orderItemId;

        private string _shipmentReference;

        private DateTime _dateTime;

        private DateTime _expectedDeliveryDate;

        private Transport _transport;

        private string _shippingLabelCode;

        
        public long OrderItemId
        {
            get
            {
                return _orderItemId;
            }
            set
            {
                _orderItemId = value;
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

        
        public DateTime DateTime
        {
            get
            {
                return _dateTime;
            }
            set
            {
                _dateTime = value;
            }
        }

        
        public DateTime ExpectedDeliveryDate
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

        
        public string ShippingLabelCode
        {
            get
            {
                return _shippingLabelCode;
            }
            set
            {
                _shippingLabelCode = value;
            }
        }
    }
}
