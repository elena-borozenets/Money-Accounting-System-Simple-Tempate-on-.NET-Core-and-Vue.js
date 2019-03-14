using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Repositories.IRepositories
{
    public interface IUserRepository
    {
        User GetUserByLogin(string login);
        User GetUserById(int id);
    }
}
