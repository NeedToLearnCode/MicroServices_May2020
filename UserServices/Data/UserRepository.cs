using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServices.Models;

namespace UserServices.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAllUser()
        {
            return (_context.Users.ToList());
        }

        public User GetUserById(int id)
        {
            return (_context.Users.FirstOrDefault(u => u.UserId == id));
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
