using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;

namespace MoneyAccountingSystem.Models
{
    public class Transaction
    {
        public string Id { get; set; }
        public TransactionType Type { get; set; }
        public double Amount { get; set; }
        public DateTime EffectiveDate { get; set; }
    }
}
