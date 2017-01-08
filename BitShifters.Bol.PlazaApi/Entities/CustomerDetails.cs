using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class CustomerDetails
    {
        private AddressDetails _shipmentDetails;

        private AddressDetails _billingDetails;

        public AddressDetails ShipmentDetails
        {
            get
            {
                return _shipmentDetails;
            }
            set
            {
                _shipmentDetails = value;
            }
        }

        public AddressDetails BillingDetails
        {
            get
            {
                return _billingDetails;
            }
            set
            {
                _billingDetails = value;
            }
        }
    }
}
