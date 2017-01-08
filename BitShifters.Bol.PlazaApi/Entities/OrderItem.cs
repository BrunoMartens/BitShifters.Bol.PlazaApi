using BitShifters.Bol.PlazaApi.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class OrderItem
    {
        private long _orderItemId;

        private string _eAN;

        private string _offerReference;

        private string _title;

        private int _quantity;

        private decimal _offerPrice;

        private decimal _transactionFee;

        private DateTime _promisedDeliveryDate;

        private bool _promisedDeliveryDateSpecified;

        private Condition _offerCondition;

        private bool _cancelRequest;

        private long _orderId;

        private long _orderItemSequenceNumber;

        private FulfilmentMethod? _fulfilmentMethod;

        public long OrderId
        {
            get
            {
                return _orderId;
            }
            set
            {
                _orderId = value;
            }
        }

        public long OrderItemSequenceNumber
        {
            get
            {
                return _orderItemSequenceNumber;
            }
            set
            {
                _orderItemSequenceNumber = value;
            }
        }

        public FulfilmentMethod? FulfilmentMethod
        {
            get
            {
                return _fulfilmentMethod;
            }
            set
            {
                _fulfilmentMethod = value;
            }
        }

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

        
        public string EAN
        {
            get
            {
                return _eAN;
            }
            set
            {
                _eAN = value;
            }
        }

        
        public string OfferReference
        {
            get
            {
                return _offerReference;
            }
            set
            {
                _offerReference = value;
            }
        }

        
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }

        
        public int Quantity
        {
            get
            {
                return _quantity;
            }
            set
            {
                _quantity = value;
            }
        }

        
        public decimal OfferPrice
        {
            get
            {
                return _offerPrice;
            }
            set
            {
                _offerPrice = value;
            }
        }

        
        public decimal TransactionFee
        {
            get
            {
                return _transactionFee;
            }
            set
            {
                _transactionFee = value;
            }
        }

        public DateTime PromisedDeliveryDate
        {
            get
            {
                return _promisedDeliveryDate;
            }
            set
            {
                _promisedDeliveryDate = value;
            }
        }

        public bool PromisedDeliveryDateSpecified
        {
            get
            {
                return _promisedDeliveryDateSpecified;
            }
            set
            {
                _promisedDeliveryDateSpecified = value;
            }
        }

        
        public Condition OfferCondition
        {
            get
            {
                return _offerCondition;
            }
            set
            {
                _offerCondition = value;
            }
        }

        
        public bool CancelRequest
        {
            get
            {
                return _cancelRequest;
            }
            set
            {
                _cancelRequest = value;
            }
        }
    }
}
