using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class Order
    {
        private long _orderId;

        private DateTime _dateTimeCustomer;

        private DateTime _dateTimeDropShipper;

        private CustomerDetails _customerDetails;

        private OrderItem[] _orderItems;

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

        public DateTime DateTimeCustomer
        {
            get
            {
                return _dateTimeCustomer;
            }
            set
            {
                _dateTimeCustomer = value;
            }
        }

        
        public DateTime DateTimeDropShipper
        {
            get
            {
                return _dateTimeDropShipper;
            }
            set
            {
                _dateTimeDropShipper = value;
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

        public OrderItem[] OrderItems
        {
            get
            {
                return _orderItems;
            }
            set
            {
                _orderItems = value;
            }
        }
    }
}
