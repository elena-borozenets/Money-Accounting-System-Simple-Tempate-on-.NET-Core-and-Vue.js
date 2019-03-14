using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using MoneyAccountingSystem.Models;
using Repositories.IRepositories;
using DB;
using DB.Models;

namespace Repositories.Repositories
{
    public class TransactionRepository: ITransactionRepository
    {

        public IEnumerable<Transaction> Get()
        {
            DBEmulate.Connect();
            var list= Mapper.Map< List < TransactionDBO >, List <Transaction>>(DBEmulate.GetTransactions());
            return list;
        }

        public IEnumerable<Transaction> GetByUser(int userId)
        {
            DBEmulate.Connect();

            var list = Mapper.Map<List<TransactionDBO>, List<Transaction>>(DBEmulate.GetTransactionsForUser(userId));
            return list;
        }

        public Transaction Get(string id)
        {
            DBEmulate.Connect();
            var list = Mapper.Map<List<TransactionDBO>, List<Transaction>>(DBEmulate.GetTransactions());
            var trans = list.Where(tr => tr.Id == id).ToList().FirstOrDefault();
            return trans;
        }

        public string Create(Transaction newTransaction)
        {
            DBEmulate.Connect();
            var newTrans = Mapper.Map<Transaction, TransactionDBO>(newTransaction);
            var id = DBEmulate.AddTransaction(newTrans);
            return id;
        }

        public double GetAmount()
        {
            return 0;
        }
    }
}
