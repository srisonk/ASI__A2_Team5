using ASI_A2_Team5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASI_A2_Team5
{
    public interface IUsersService
    {
        public List<User> GetUsers();

        public User AddUser(User user);

        public User UpdateUser(string id, User user);

        public string DeleteUser(string id);
    }
}
