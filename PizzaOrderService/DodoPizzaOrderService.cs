using System;
using System.Collections.Generic;
using System.Text;
using PizzaOrderService.Domain;

namespace PizzaOrderService
{
    /// <summary>
    /// Сервис по предоставлению данных Dodo-пиццы 
    /// </summary>
    public class DodoPizzaOrderService
        : IPizzaOrderService
    {
        public Pizza[] GetAvailablePizza()
        {
            throw new NotImplementedException();
        }

        public bool OrderPizza(OrderRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
