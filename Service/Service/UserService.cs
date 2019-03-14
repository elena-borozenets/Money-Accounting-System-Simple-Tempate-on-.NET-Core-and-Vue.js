using System;
using System.Collections.Generic;
using System.Text;
using Models;
using Repositories.IRepositories;
using Service.IService;

namespace Service.Service
{
    public class UserService: IUserService
    {
        private IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public bool CheckUser(User user)
        {
            var findUser = _userRepository.GetUserByLogin(user.Login);
            return (findUser.Login == user.Login && findUser.Password == user.Password) ? true : false;
        }
    }
}
