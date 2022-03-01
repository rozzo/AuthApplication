﻿using System.Collections.Generic;
using System.Threading.Tasks;
using AuthApplication.Authentication.Models;

namespace AuthApplication.Authentication.Services
{
    public interface IUserService
    {
        Task<User> Authenticate(string username, string password);
        Task<IEnumerable<User>> GetAll();
    }
}