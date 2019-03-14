using System;
using System.Collections.Generic;
using System.Text;
using Models;
using MoneyAccountingSystem.Models;

namespace Repositories.IRepositories
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> Get();
        Transaction Get(string id);
        string Create(Transaction newTransaction);
        double GetAmount();
    }
}
