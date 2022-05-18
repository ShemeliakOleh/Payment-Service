using Payment_Service.Models;

namespace Payment_Service.Data.Repository
{
    public interface ITransactionRepository
    {
        public TransactionPowerApps Get(string id);
        public TransactionPowerApps Create(TransactionPowerApps transaction);
        public TransactionResult Process(string id);
    }
}
