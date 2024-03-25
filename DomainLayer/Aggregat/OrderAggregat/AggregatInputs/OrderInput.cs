using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Aggregat.OrderAggregat.AggregatInputs
{
    public class OrderInput
    {

        public decimal total { get; set; }
        public List<OrderItemInput> orderitems { get; set; } = new();
    }
}
