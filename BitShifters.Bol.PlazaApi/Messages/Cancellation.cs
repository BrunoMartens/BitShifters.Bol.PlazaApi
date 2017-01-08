using BitShifters.Bol.PlazaApi.Enum;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Messages
{
    public class Cancellation
    {
        private DateTime _dateTime;

        private ReasonCode _reasonCode;


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

        
        public ReasonCode ReasonCode
        {
            get
            {
                return _reasonCode;
            }
            set
            {
                _reasonCode = value;
            }
        }
    }
}
