using System.Transactions;

namespace Payment_Service.Data.Repository
{
    public interface ITransactionRepository
    {
        public Transaction GetTransaction(string transactionName);
        public Transaction CreateTransaction(Transaction transaction);
        public Transaction UpdateTransaction(Transaction transaction);
    }
}
