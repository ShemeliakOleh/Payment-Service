﻿using Payment_Service.Data.Repository;
using Payment_Service.Models;

namespace Payment_Service.Data.RepositoryImpl
{
    public class TransactionHistoryRepository :BaseRepository,ITransactionHistoryRepository
    {
        public TransactionHistoryRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public TransactionHistory Create(TransactionHistory transactionHistory)
        {
            throw new NotImplementedException();
        }

        public TransactionHistory Get(string transactionHistoryName)
        {
            throw new NotImplementedException();
        }
    }
}
