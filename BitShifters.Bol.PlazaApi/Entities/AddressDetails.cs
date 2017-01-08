using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class AddressDetails
    {
        private string _salutationCode;

        private string _firstname;

        private string _surname;

        private string _streetname;

        private string _housenumber;

        private string _housenumberExtended;

        private string _addressSupplement;

        private string _extraAddressInformation;

        private string _zipCode;

        private string _city;

        private string _countryCode;

        private string _email;

        private string _company;

        private string _vatNumber;

        private string _deliveryPhoneNumber;

        
        public string SalutationCode
        {
            get
            {
                return _salutationCode;
            }
            set
            {
                _salutationCode = value;
            }
        }

        
        public string Firstname
        {
            get
            {
                return _firstname;
            }
            set
            {
                _firstname = value;
            }
        }

        
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                _surname = value;
            }
        }

        
        public string Streetname
        {
            get
            {
                return _streetname;
            }
            set
            {
                _streetname = value;
            }
        }

        
        public string Housenumber
        {
            get
            {
                return _housenumber;
            }
            set
            {
                _housenumber = value;
            }
        }

        
        public string HousenumberExtended
        {
            get
            {
                return _housenumberExtended;
            }
            set
            {
                _housenumberExtended = value;
            }
        }

        
        public string AddressSupplement
        {
            get
            {
                return _addressSupplement;
            }
            set
            {
                _addressSupplement = value;
            }
        }

        
        public string ExtraAddressInformation
        {
            get
            {
                return _extraAddressInformation;
            }
            set
            {
                _extraAddressInformation = value;
            }
        }

        
        public string ZipCode
        {
            get
            {
                return _zipCode;
            }
            set
            {
                _zipCode = value;
            }
        }

        
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                _city = value;
            }
        }

        
        public string CountryCode
        {
            get
            {
                return _countryCode;
            }
            set
            {
                _countryCode = value;
            }
        }

        
        public string Email
        {
            get
            {
                return _email;
            }
            set
            {
                _email = value;
            }
        }

        
        public string Company
        {
            get
            {
                return _company;
            }
            set
            {
                _company = value;
            }
        }

        
        public string VatNumber
        {
            get
            {
                return _vatNumber;
            }
            set
            {
                _vatNumber = value;
            }
        }

        
        public string DeliveryPhoneNumber
        {
            get
            {
                return _deliveryPhoneNumber;
            }
            set
            {
                _deliveryPhoneNumber = value;
            }
        }
    }
}
