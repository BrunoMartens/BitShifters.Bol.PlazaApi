using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace BitShifters.Bol.PlazaApi.Exceptions
{
    public class ServiceExceptionData
    {

        public string ErrorMessage { get; set; }

        public string ErrorCode { get; set; }

        public string errorMessage { get; set; }

        public string errorCode { get; set; }
    }
}
