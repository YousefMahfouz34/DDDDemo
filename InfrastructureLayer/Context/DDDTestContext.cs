using DomainLayer.Aggregat.OrderAggregat;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfrastructureLayer.Context
{
    public  class DDDTestContext:DbContext
    {
        public DbSet<Order> orders {  get; set; }
        public DDDTestContext(DbContextOptions<DDDTestContext> options) : base(options)
        {

        }
    }
}
