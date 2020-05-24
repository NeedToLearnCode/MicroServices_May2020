using Microsoft.EntityFrameworkCore;
using OrderServices.Models;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Data
{
    public class OrderContext:DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> opt) : base(opt)
        {

        }

        public DbSet<Order> Orders { get; set; }
    }
}
