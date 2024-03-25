using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Aggregat.OrderAggregat.Reposatory
{
    public  interface IOrderReposatory
    {
        Task<IEnumerable<Order>> GetOrders();
        Task<Order> GetOrderById(int id);
        Task Create(Order order);
        Task  SaveChangesAsync();

    }
}
