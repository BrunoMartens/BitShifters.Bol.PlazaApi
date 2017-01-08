using System;
using System.Collections.Generic;
using System.Text;

namespace BitShifters.Bol.PlazaApi.Entities
{
    public class ShipmentItem
    {
        private OrderItem _orderItem;

        public OrderItem OrderItem
        {
            get
            {
                return _orderItem;
            }
            set
            {
                _orderItem = value;
            }
        }
    }
}
