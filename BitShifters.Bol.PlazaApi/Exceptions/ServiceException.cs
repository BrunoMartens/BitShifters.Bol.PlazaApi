using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Exceptions
{
    class ServiceException: Exception
    {
        //inconsistent bol api :(
        public ServiceException(ServiceExceptionData data): base($"({data.ErrorCode + data.errorCode}) {data.ErrorMessage + data.errorMessage}")
        {
            ErrorCode = data.ErrorCode + data.errorCode;
            ErrorMessage = data.ErrorMessage + data.errorMessage;
        }

        public string ErrorCode { get; private set; }

        public string ErrorMessage { get; private set; }
    }
}
