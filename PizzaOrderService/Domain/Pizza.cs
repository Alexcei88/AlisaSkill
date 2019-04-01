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
        public IEnumerable<Size> Sizes { get; set; }

        public class Size
        { 
            public double Diameter { get; set; }
            public string Dough { get; set; }
            public decimal Price { get; set; }
        }

        /// <summary>
        /// Описание ингредиентов
        /// </summary>
        public string IngredientsDescription { get; set; }

    }
}
