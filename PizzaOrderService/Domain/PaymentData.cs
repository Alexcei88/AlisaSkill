using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderService.Domain
{
    public class PaymentData
    {
        public string CardNumber { get; set; }

        public string ValidityDate { get; set; }

        public int CVC { get; set;  }
    }
}
