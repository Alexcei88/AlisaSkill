using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaOrderService.Domain
{
    /// <summary>
    /// Объект пицца
    /// </summary>
    public class Pizza
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Название 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Размер 
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Цена 
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Описание интградиентов
        /// </summary>
        public string IntgradientDescription { get; set; }

    }
}
