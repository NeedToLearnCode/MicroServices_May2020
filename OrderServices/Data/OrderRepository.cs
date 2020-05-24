using OrderServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Data
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderContext _context;

        public OrderRepository(OrderContext context)
        {
            _context = context;
        }
        public IEnumerable<Order> GetAllOrders()
        {
            return (_context.Orders.ToList());
        }

        public Order GetOrderById(int id)
        {
            return (_context.Orders.FirstOrDefault(o => o.OrderId == id));
        }
    }
}
