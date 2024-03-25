using DomainLayer.Aggregat.OrderAggregat;
using DomainLayer.Aggregat.OrderAggregat.Reposatory;
using InfrastructureLayer.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Reposatory
{
    public class OrderReposatory : IOrderReposatory
    {
        private readonly DDDTestContext context;

        public OrderReposatory(DDDTestContext _context)
        {
            context = _context;
        }
        public async Task Create(Order order)
        {
            await context.orders.AddAsync(order);
        }

        public async Task<Order> GetOrderById(int id)
        {
            var order = await context.orders.Include(o => o.ordersList).FirstOrDefaultAsync(o => o.Id == id);
            return order;
        }

        public async Task<IEnumerable<Order>> GetOrders()
        {
            var res =  await context.orders.Include(o => o.ordersList).ToListAsync();
            return res;    
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
