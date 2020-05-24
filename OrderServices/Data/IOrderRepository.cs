using OrderServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderServices.Data
{
    public interface IOrderRepository
    {
        public IEnumerable<Order> GetAllOrders();
        public Order GetOrderById(int id);
    }
}
