using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class Transport
    {
        private long _transportId;

        private bool _transportIdSpecified;

        private string _transporterCode;

        private string _trackAndTrace;

        private long _shippingLabelId;

        private bool _shippingLabelIdSpecified;

        
        public long TransportId
        {
            get
            {
                return _transportId;
            }
            set
            {
                _transportId = value;
            }
        }

        public bool TransportIdSpecified
        {
            get
            {
                return _transportIdSpecified;
            }
            set
            {
                _transportIdSpecified = value;
            }
        }

        
        public string TransporterCode
        {
            get
            {
                return _transporterCode;
            }
            set
            {
                _transporterCode = value;
            }
        }

        
        public string TrackAndTrace
        {
            get
            {
                return _trackAndTrace;
            }
            set
            {
                _trackAndTrace = value;
            }
        }

        
        public long ShippingLabelId
        {
            get
            {
                return _shippingLabelId;
            }
            set
            {
                _shippingLabelId = value;
            }
        }

        public bool ShippingLabelIdSpecified
        {
            get
            {
                return _shippingLabelIdSpecified;
            }
            set
            {
                _shippingLabelIdSpecified = value;
            }
        }
    }
}
