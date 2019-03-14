using System;
using System.Collections.Generic;
using System.Text;

namespace DB.Models
{
    public class TransactionDBO
    {
        public string Id { get; set; }
        public TransactionTypeDBO Type { get; set; }
        public double Amount { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int UserId { get; set; }
    }
}
