using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UserServices.Data;
using UserServices.Models;

namespace UserServices.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUser()
        {
            var userItems = _repository.GetAllUser();
            return Ok(userItems);

        }

        [HttpGet("{id}", Name = "GetUserById")]
        public ActionResult<User> GetUserById(int id)
        {
            var useritem = _repository.GetUserById(id);
            if (useritem != null)
            {
                return Ok(useritem);
            }
            return NotFound();
        }

    }
}