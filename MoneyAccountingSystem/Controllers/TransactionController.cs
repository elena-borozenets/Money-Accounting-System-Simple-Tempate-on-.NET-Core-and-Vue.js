using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using MoneyAccountingSystem.Models;
using Repositories.IRepositories;
using Service;
using Service.IService;

namespace MoneyAccountingSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        private ITransactionService _transactionService;

        public TransactionController(ITransactionService transactionService)
        {
            _transactionService = transactionService;
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<Transaction> Get()
        {
            return _transactionService.GetTransactions();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public Transaction Get(string id)
        {
            return _transactionService.GetTransactionById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] TransactionBody value)
        {
            _transactionService.AddTransaction(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
