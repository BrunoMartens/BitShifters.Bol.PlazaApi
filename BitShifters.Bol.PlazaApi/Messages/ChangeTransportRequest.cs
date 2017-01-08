using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Messages
{
    public class ChangeTransportRequest
    {
        private string _transporterCode;

        private string _trackAndTrace;

        
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
    }
}
