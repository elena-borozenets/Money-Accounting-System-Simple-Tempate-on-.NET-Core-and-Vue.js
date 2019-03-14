using System;
using System.Collections.Generic;
using System.Text;
using Models;

namespace Service.IService
{
    public interface IUserService
    {
        bool CheckUser(User user);
    }
}
