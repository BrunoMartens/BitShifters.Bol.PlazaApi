using BitShifters.Bol.PlazaApi.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class PurchasableShippingLabel
    {
        private string _transporterCode;

        private LabelType _labelType;

        private string _maxWeight;

        private string _maxDimensions;

        private decimal _retailPrice;

        private decimal _purchasePrice;

        private decimal _discount;

        private string _shippingLabelCode;

        
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

        
        public LabelType LabelType
        {
            get
            {
                return _labelType;
            }
            set
            {
                _labelType = value;
            }
        }

        
        public string MaxWeight
        {
            get
            {
                return _maxWeight;
            }
            set
            {
                _maxWeight = value;
            }
        }

        
        public string MaxDimensions
        {
            get
            {
                return _maxDimensions;
            }
            set
            {
                _maxDimensions = value;
            }
        }

        
        public decimal RetailPrice
        {
            get
            {
                return _retailPrice;
            }
            set
            {
                _retailPrice = value;
            }
        }

        
        public decimal PurchasePrice
        {
            get
            {
                return _purchasePrice;
            }
            set
            {
                _purchasePrice = value;
            }
        }

        
        public decimal Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                _discount = value;
            }
        }

        
        public string ShippingLabelCode
        {
            get
            {
                return _shippingLabelCode;
            }
            set
            {
                _shippingLabelCode = value;
            }
        }
    }
}
