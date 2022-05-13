using Payment_Service.Data.Repository;

namespace Payment_Service.Data
{
    public class DataManager
    {
        public ICustomerRepository Customers { get; set; }
        public ITransactionRepository Transactions { get; set; }
        public ITransactionHistoryRepository TransactionHistories { get; set; }

        public DataManager(ICustomerRepository customerRepository, ITransactionHistoryRepository transactionHistoryRepository, ITransactionRepository transactionRepository)
        {
            this.Customers = customerRepository;
            this.Transactions = transactionRepository;
            this.TransactionHistories = transactionHistoryRepository;
        }

    }
}
