using Microsoft.Extensions.Logging;
using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Infrastructure.Persistence
{
    public class OrderContextSeed
    {
        public static async Task SeedAsync(OrderContext context,ILogger<OrderContextSeed> logger)
        {
            if(!context.Orders.Any())
            {
                context.Orders.AddRange(GetPreconfigurationOrders());
                await context.SaveChangesAsync();

            }
        }

        private static IEnumerable<Order> GetPreconfigurationOrders() {
            return new List<Order>
            {
                new Order() {UserName = "swn", FirstName = "Mehmet", LastName = "Ozkaya", EmailAddress = "ezozkme@gmail.com", AddressLine = "Bahcelievler", Country = "Turkey", TotalPrice = 350 }
            };
        }
    }
}
