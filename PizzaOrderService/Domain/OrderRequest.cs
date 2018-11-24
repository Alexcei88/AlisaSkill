using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderService.Domain
{
    /// <summary>
    /// Запрос на заказ пиццы
    /// </summary>
    public class OrderRequest
    {
        public int IdPizza { get; set; }

        public DeliveryAddress  Address { get; set; }

        public PaymentData Payment { get; set; } 
    }
}
