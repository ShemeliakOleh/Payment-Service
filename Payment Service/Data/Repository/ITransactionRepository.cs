using System.Transactions;

namespace Payment_Service.Data.Repository
{
    public interface ITransactionRepository
    {
        public Transaction Get(string transactionName);
        public Transaction Create(Transaction transaction);
        public Transaction Update(Transaction transaction);
    }
}
