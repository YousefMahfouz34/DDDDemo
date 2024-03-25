using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Aggregat.OrderAggregat.AggregatInputs
{
    public class OrderUpdateInput
    {
        public decimal total { get; set; }
        public List<OrderItemUpdateInput> orderupdateitems { get; set; } = new();
    }
}
