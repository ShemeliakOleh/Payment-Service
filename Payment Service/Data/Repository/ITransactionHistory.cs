using Payment_Service.Models;

namespace Payment_Service.Data.Repository
{
    public interface ITransactionHistory
    {
        public TransactionHistory GetTransaction(string transactionHistoryName);
        public TransactionHistory CreateTransaction(TransactionHistory transactionHistory);
    }
}
