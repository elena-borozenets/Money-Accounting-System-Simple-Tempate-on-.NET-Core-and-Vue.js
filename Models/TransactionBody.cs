using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class TransactionBody
    {
        public TransactionType Type { get; set; }
        public double Amount { get; set; }
    }
}
