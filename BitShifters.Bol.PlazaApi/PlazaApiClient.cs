using BitShifters.Bol.PlazaApi.Repositories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BitShifters.Bol.PlazaApi
{
    public class PlazaApiClient
    {

        public PlazaApiClient(OrderRepository orderRepository, 
                                ShipmentRepository shipmentRepository,
                                ShippingLabelRepository shippingLabelRepository,
                                ReturnItemRepository returnItemRepository,
                                ProcessStatusRepository processStatusRepository)
        {
            OrderRepository = orderRepository;
            ShipmentRepository = shipmentRepository;
            ShippingLabelRepository = shippingLabelRepository;
            ReturnItemRepository = returnItemRepository;
            ProcessStatusRepository = processStatusRepository;
        }

        public OrderRepository OrderRepository { get; private set; }

        public ShipmentRepository ShipmentRepository { get; private set; }

        public ShippingLabelRepository ShippingLabelRepository { get; private set; }

        public ReturnItemRepository ReturnItemRepository { get; private set; }

        public ProcessStatusRepository ProcessStatusRepository { get; private set; }

    }
}
