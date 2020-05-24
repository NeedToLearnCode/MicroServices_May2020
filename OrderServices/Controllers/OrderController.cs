using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrderServices.Data;
using OrderServices.Models;

namespace OrderServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _repository;

        public OrderController(IOrderRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Order>> GetAllUser()
        {
            var orderItems = _repository.GetAllOrders();
            return Ok(orderItems);

        }

        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult<Order> GetUserById(int id)
        {
            var orderitem = _repository.GetOrderById(id);
            if (orderitem != null)
            {
                return Ok(orderitem);
            }
            return NotFound();
        }


    }
}