using Payment_Service.Data;
using Payment_Service.Models;

namespace Payment_Service.Services
{
    public class TransactionPowerAppsService
    {

        private readonly DataManager _data;

        public TransactionPowerAppsService(DataManager dataManager)
        {
            this._data = dataManager;
        }


        public TransactionPowerApps Create(TransactionPowerApps transaction)
        {
            
            return _data.Transactions.Create(transaction);
        }

        public TransactionHistory ProcessTransaction(string id)
        {
            TransactionHistory transactionHistory = new TransactionHistory();

            var processResult = _data.Transactions.Process(id);

            if (processResult.IsSuccessfulProcess)
            {
                transactionHistory.Result = "200";
                transactionHistory.Message = processResult.ErrorMessage;
                transactionHistory.Transaction = _data.Transactions.Get(id);
                transactionHistory.Name = Guid.NewGuid().ToString();
            }
            else
            {
                transactionHistory.Result = "500";
                transactionHistory.Message = processResult.ErrorMessage;
                transactionHistory.Transaction = _data.Transactions.Get(id);
                transactionHistory.Name = Guid.NewGuid().ToString();
            }

            return transactionHistory;
        }


    }
}
