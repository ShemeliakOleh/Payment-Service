using Payment_Service.Data;
using Payment_Service.Models;

namespace Payment_Service.Services
{
    public class TransactionHistoryService
    {
        private readonly DataManager _data;

        public TransactionHistoryService(DataManager dataManager)
        {
            this._data = dataManager;
        }


        public TransactionHistory Create(TransactionHistory transactionHistory)
        {
            return _data.TransactionHistories.Create(transactionHistory);
        }

        public TransactionHistory Get(string transactionHistoryName)
        {
            return _data.TransactionHistories.Get(transactionHistoryName);
        }
    }
}
