using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserServices.Models;

namespace UserServices.Data
{
   public interface IUserRepository
    {
        bool SaveChanges();
        IEnumerable<User> GetAllUser();
        User GetUserById(int id);
    }
}
