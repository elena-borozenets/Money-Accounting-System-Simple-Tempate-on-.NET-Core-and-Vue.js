using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;
using AutoMapper;
using DB.Models;
using Models;

namespace Repositories
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<TransactionType, TransactionTypeDBO>();
            CreateMap<TransactionTypeDBO, TransactionType>();
            CreateMap<Transaction, TransactionDBO>();
            CreateMap<TransactionDBO, Transaction>();
            CreateMap<UserDBO, User>();
            CreateMap<User, UserDBO>();

        }
    }
}
