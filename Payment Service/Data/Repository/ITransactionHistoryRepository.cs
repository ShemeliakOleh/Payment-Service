using Payment_Service.Models;

namespace Payment_Service.Data.Repository
{
    public interface ITransactionHistoryRepository
    {
        public TransactionHistory Get(string id);
        public TransactionHistory Create(TransactionHistory transactionHistory);
    }
}
