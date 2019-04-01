using Microsoft.Extensions.DependencyInjection;
using Moq;
using PizzaOrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliceSkillService.Extensions
{
    public static class ServicesConfigurationExtension
    {
        public static void AddDodoPizzaOrderService(this IServiceCollection services)
        {
            services.AddTransient<IPizzaOrderService, DodoPizzaOrderService>();
        }

        public static void AddFakeDodoPizzaOrderService(this IServiceCollection services)
        {          
            services.AddTransient<IPizzaOrderService>(a =>
            {
                Mock<IPizzaOrderService> service = new Mock<IPizzaOrderService>();
                service.Setup(s => s.GetAvailablePizzas()).Returns(new PizzaOrderService.Domain.Pizza[]
                {
                new PizzaOrderService.Domain.Pizza()
                {
                    Id = 1,
                    IngredientsDescription = "Мясо, молоко",
                    Name = "Мясная",
                    Price = 30.00m,
                    Size = new int[]{10,20,25}
                },
                new PizzaOrderService.Domain.Pizza()
                {
                    Id = 2,
                    IngredientsDescription = "Мясо, молоко",
                    Name = "Молочная",
                    Price = 30.00m,
                    Size = new int[]{10,20,25}
                },
                new PizzaOrderService.Domain.Pizza()
                {
                    Id = 3,
                    IngredientsDescription = "Сыр",
                    Name = "С сыром",
                    Price = 30.00m,
                    Size = new int[]{10,20,25}
                }
                });
                return service.Object;
            });
        }
    }
}
