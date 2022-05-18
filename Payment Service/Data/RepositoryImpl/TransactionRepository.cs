using Payment_Service.Data.Repository;
using Payment_Service.Models;
using System.Transactions;

namespace Payment_Service.Data.RepositoryImpl
{
    public class TransactionRepository :BaseRepository, ITransactionRepository
    {
        public TransactionRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public TransactionPowerApps Create(TransactionPowerApps transaction)
        {
            db.Transactions.Add(transaction);
            db.SaveChanges();
            return transaction;
        }

        public TransactionPowerApps Get(string id)
        {
           return db.Transactions.FirstOrDefault(x=>x.Id == id);
        }

        public TransactionResult Process(string id)
        {
            TransactionResult result = new TransactionResult();

            using (var dbContextTransaction = db.Database.BeginTransaction())
            {

                try
                {
                    var transactionFromDb = db.Transactions.FirstOrDefault(x => x.Id == id);

                    if (transactionFromDb != null)
                    {
                        transactionFromDb.Completed = true;
                        db.SaveChanges();
                    }

                    dbContextTransaction.Commit();
                    result.IsSuccessfulProcess = true;
                }
                catch (Exception ex)
                {
                    dbContextTransaction.Rollback();
                    result.IsSuccessfulProcess = false;
                    result.ErrorMessage = ex.Message;
                }

            }
            return result;
        }
    }
}
