using System;
using System.Collections.Generic;
using Models;
using MoneyAccountingSystem.Models;
using Repositories.IRepositories;
using Service.IService;


namespace Service
{
    public class TransactionService: ITransactionService
    {
        private ITransactionRepository _transactionRepository;
        public TransactionService(ITransactionRepository transactionRepository)
        {
            _transactionRepository = transactionRepository;
        }

        public IEnumerable<Transaction> GetTransactions()
        {
            return _transactionRepository.Get();
        }

        public Transaction GetTransactionById(string id)
        {
            return _transactionRepository.Get(id);
        }

        public string AddTransaction(TransactionBody transaction)
        {
            var newTransaction = new Transaction()
            {
                Type = transaction.Type,
                Amount = transaction.Amount,
                EffectiveDate = DateTime.UtcNow
            };
            return _transactionRepository.Create(newTransaction);
        }

        public double GetAmount()
        {
            return _transactionRepository.GetAmount();
        }
    }
}
