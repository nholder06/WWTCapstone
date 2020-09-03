﻿using System;
using System.Collections.Generic;
using System.Linq;
using WWTCapstone_api.Helpers;
using WWTCapstone_api.Models;

namespace WWTCapstone_api.Services
{
    public interface IUserService
    {
        User Authenticate(string email, string password);
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user, string password);
        void Update(User user, string password = null);
        void Delete(int id);
    }
}


