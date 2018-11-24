using PizzaOrderService.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderService
{
    public interface IPizzaOrderService
    {
        /// <summary>
        /// Список доступных пицц
        /// </summary>
        /// <returns></returns>
        Pizza[] GetAvailablePizza();

        /// <summary>
        /// Купить пиццу
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        bool OrderPizza(OrderRequest request);
    }
}
