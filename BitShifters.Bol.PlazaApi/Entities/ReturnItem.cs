using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class ReturnItem
    {
        private long _returnNumber;

        private long _orderId;

        private long _shipmentId;

        private bool _shipmentIdSpecified;

        private string _eAN;

        private string _title;

        private int _quantity;

        private DateTime _returnDateAnnouncement;

        private bool _returnDateAnnouncementSpecified;

        private string _returnReason;

        private string _returnReasonComments;

        private CustomerDetails _customerDetails;

        
        public long ReturnNumber
        {
            get
            {
                return _returnNumber;
            }
            set
            {
                _returnNumber = value;
            }
        }

        
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


        public DateTime ReturnDateAnnouncement
        {
            get
            {
                return _returnDateAnnouncement;
            }
            set
            {
                _returnDateAnnouncement = value;
            }
        }

        
        public bool ReturnDateAnnouncementSpecified
        {
            get
            {
                return _returnDateAnnouncementSpecified;
            }
            set
            {
                _returnDateAnnouncementSpecified = value;
            }
        }

        
        public string ReturnReason
        {
            get
            {
                return _returnReason;
            }
            set
            {
                _returnReason = value;
            }
        }

        
        public string ReturnReasonComments
        {
            get
            {
                return _returnReasonComments;
            }
            set
            {
                _returnReasonComments = value;
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
