using System.Threading.Tasks;
using Xunit;
using PizzaOrderService;

namespace PizzaOrderServiceTest
{
    public class DodoPizzaTest
    {
        [Fact]
        public async Task GetAvailablePizzasNotNull()
        {
            var service = new DodoPizzaOrderService();
            var availablePizzas = await service.GetAvailablePizzas();
            Assert.NotEmpty(availablePizzas);
        }
    }
}