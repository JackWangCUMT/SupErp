﻿using SupErpModuleUser.Models;
using SupErpModuleUser.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupErpModuleUser.Helpers
{
    public static class UserAdapter
    {
        public static IHMUser ToIHMUser(this User user)
        {
            return new IHMUser(user);
        }

        public static User ToUser(this IHMUser user)
        {
            return new User()
            {
                Id = user.Id,
                Email = user.Email,
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Address = user.Address,
                Role = user.Role.ToRole(),
                Role_id = user.Role.Id
            };
        }
    }
}
