﻿using Payment_Service.Data.Repository;
using System.Transactions;

namespace Payment_Service.Data.RepositoryImpl
{
    public class TransactionRepository : ITransactionRepository
    {
        public Transaction Create(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public Transaction Get(string transactionName)
        {
            throw new NotImplementedException();
        }

        public Transaction Update(Transaction transaction)
        {
            throw new NotImplementedException();
        }
    }
}