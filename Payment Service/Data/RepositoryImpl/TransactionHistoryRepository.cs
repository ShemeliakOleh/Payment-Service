using Payment_Service.Data.Repository;
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
            db.TransactionHistories.Add(transactionHistory);
            db.SaveChanges();
            return transactionHistory;

        }

        public TransactionHistory Get(string name)
        {
            return db.TransactionHistories.FirstOrDefault(x=>x.Name == name);
        }
    }
}
