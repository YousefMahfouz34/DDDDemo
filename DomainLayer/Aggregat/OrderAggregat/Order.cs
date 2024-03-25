using DomainLayer.Aggregat.OrderAggregat.AggregatInputs;
using DomainLayer.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Aggregat.OrderAggregat
{
    public  class Order:BaseEntity
    {
        public decimal total { get; private set; }
        private readonly List<OrderItem> orders = new();
        public virtual IReadOnlyCollection<OrderItem> ordersList => orders;
        public Order()
        {
            
        }
        public Order(OrderInput orderInput)
        {
            this.total = orderInput.total;
            this.createdAt=DateTime.Now;
            this.IsDeleted = false;
            foreach (var item in orderInput.orderitems)
            {
                orders.Add(new OrderItem(item));
                
            }
        }

        public void Update(OrderUpdateInput orderupdateInput) 
        {
            this.total += orderupdateInput.total;
            this.createdAt = DateTime.Now;
            foreach (var item in orderupdateInput.orderupdateitems)
            {
              var orderitem= orders.Where(o=>o.Id == item.Id).SingleOrDefault();
                if (orderitem != null) 
                {
                    orderitem.Update(item);

                }
                
            }

        }
        public void Delete()
        {
            this.IsDeleted=true;
            foreach (var item in orders) 
            {
                item.Delete();
            }

        }

    }
}
