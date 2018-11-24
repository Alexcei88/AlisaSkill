using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderService.Domain
{
    public class DeliveryAddress
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public string Street { get; set; }

        public int HouseNumber { get; set; }

        public int ApartmentNumber { get; set; }

        public int FloorNumber { get; set; }
    }
}
