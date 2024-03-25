using DomainLayer.Aggregat.OrderAggregat.AggregatInputs;
using DomainLayer.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Aggregat.OrderAggregat
{
    public  class OrderItem:BaseEntity
    {
        public string name { get; private set; }
        [ForeignKey(nameof(OrderItem.Order))]
        public string orderId { get; private set;}
        public decimal price { get; private set; }
        public virtual Order Order { get; private set; }
        public OrderItem() { }
        public OrderItem(OrderItemInput orderItemInput)
        {
            this.IsDeleted = false;
            this.createdAt= DateTime.Now;   
            this.name = orderItemInput.name;
            this.price = orderItemInput.price;
            
        }
        public void Update(OrderItemUpdateInput orderItemInput)
        {
            this.name = orderItemInput.name;
            this.price = orderItemInput.price;
        }
        public void Delete() 
        {
            this.IsDeleted = true;
        }

      
    }
}
