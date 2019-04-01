using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using PizzaOrderService.Domain;
using PizzaOrderService.Domain.Dodo;
using Pizza = PizzaOrderService.Domain.Pizza;

namespace PizzaOrderService
{
    /// <summary>
    /// Сервис по предоставлению данных Dodo-пиццы 
    /// </summary>
    public class DodoPizzaOrderService : IPizzaOrderService
    {
        public async Task<IEnumerable<Pizza>> GetAvailablePizzas()
        {
            WebClient webClient = new WebClient();
            var url = "https://dodopizza.ru/kirov/";
            var page = await webClient.DownloadStringTaskAsync(url);
            string stateJson = Regex.Match(page, @"window\.initialState = (.+);</script>", RegexOptions.Multiline)
                .Groups[1].Value;

            var dodoPizzaData = DodoPizzaData.FromJson(stateJson);
            return dodoPizzaData.Menu.Pizzas.Select(x => new Pizza
            {
                Name = x.Name,
                IngredientsDescription = x.CompositionDescription,
                Sizes = x.Products.Select(s => new Pizza.Size
                {
                    Price = s.MenuProduct.Price.Value,
                    Diameter = s.MenuProduct.Product.Size.Value,
                    Dough = s.Dough.ToString()
                })
            });
        }

        public bool OrderPizza(OrderRequest request)
        {
            throw new NotImplementedException();
        }
    }
}