using BitShifters.Bol.PlazaApi.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Messages
{
    public class ReturnItemStatusUpdate
    {
        private StatusReason _statusReason;

        private int _quantityReturned;

        
        public StatusReason StatusReason
        {
            get
            {
                return _statusReason;
            }
            set
            {
                _statusReason = value;
            }
        }

        
        public int QuantityReturned
        {
            get
            {
                return _quantityReturned;
            }
            set
            {
                _quantityReturned = value;
            }
        }
    }
}
