using System;
using System.Collections.Generic;
using System.Linq;
using DB.Models;



namespace DB
{
    public class DBEmulate
    {
        private List<TransactionDBO> transactions;
        private List<UserDBO> users;

        //public List<TransactionDBO> Transactions => transactions;

        private DBEmulate()
        {
            transactions = new List<TransactionDBO>
            {
                new TransactionDBO()
                {
                    Id="1",
                    Type = TransactionTypeDBO.credit,
                    Amount = 500,
                    EffectiveDate = DateTime.UtcNow.AddDays(-1),
                    UserId = 1
                },
                new TransactionDBO()
                {
                    Id="2",
                    Type = TransactionTypeDBO.debit,
                    Amount = 350,
                    EffectiveDate = DateTime.UtcNow.AddDays(-2),
                    UserId = 1

                },
                new TransactionDBO()
                {
                    Id="3",
                    Amount = 350,
                    EffectiveDate = DateTime.UtcNow.AddDays(-2),
                    UserId=1
                }
            };

            users = new List<UserDBO>
            {
                new UserDBO()
                {
                    Id=1,
                    Login = "admin",
                    Password = "123"
                }
            };
        }

        private static DBEmulate db;

        public static DBEmulate Connect()
        {
            if (db == null)
            {
                db = new DBEmulate();
            }

            return db;
        }

        public static List<TransactionDBO> GetTransactions()
        {
            return db.transactions;
        }

        public static List<TransactionDBO> GetTransactionsForUser(int userId)
        {
            return db.transactions.Where(tr=>tr.UserId==userId).ToList();
        }

        public static List<UserDBO> GetUsers()
        {
            return db.users;
        }

        public static string AddTransaction(TransactionDBO t)
        {
            t.Id = new Guid().ToString();
            db?.transactions.Add(t);
            return t.Id;
        }

    }
}
