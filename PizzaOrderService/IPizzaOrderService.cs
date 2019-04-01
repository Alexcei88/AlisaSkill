using PizzaOrderService.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PizzaOrderService
{
    public interface IPizzaOrderService
    {
        /// <summary>
        /// Список доступных пицц
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Pizza>> GetAvailablePizzas();

        /// <summary>
        /// Купить пиццу
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        bool OrderPizza(OrderRequest request);
    }
}
