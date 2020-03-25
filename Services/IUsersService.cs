﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A2UserCRUD.Services
{
    public interface IUsersService
    {
        public List<User> GetUsers();

        public User AddUser(User user);

        public User UpdateUser(string id, User user);

        public string DeleteUser(string id);
    }
}
