using System;
using System.Collections.Generic;
using System.Text;
using Models;
using MoneyAccountingSystem.Models;

namespace Service.IService
{
    public interface ITransactionService
    {
        IEnumerable<Transaction> GetTransactions();
        Transaction GetTransactionById(string id);
        string AddTransaction(TransactionBody transaction);
        double GetAmount();
    }
}
