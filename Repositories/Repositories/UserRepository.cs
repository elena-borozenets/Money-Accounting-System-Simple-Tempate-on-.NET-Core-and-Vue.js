using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using DB;
using DB.Models;
using Models;
using Repositories.IRepositories;

namespace Repositories.Repositories
{
    public class UserRepository: IUserRepository
    {
        public User GetUserByLogin(string login)
        {
            DBEmulate.Connect();
            var list = Mapper.Map<List<UserDBO>, List<User>>(DBEmulate.GetUsers());
            var user = list.FirstOrDefault(u => u.Login == login);
            return user;
        }

        public User GetUserById(int id)
        {
            DBEmulate.Connect();
            var list = Mapper.Map<List<UserDBO>, List<User>>(DBEmulate.GetUsers());
            var user = list.FirstOrDefault(u => u.Id == id);
            return user;
        }
    }
}
