using Payment_Service.Data;
using Payment_Service.Models;

namespace Payment_Service.Services
{
    public class CustomerService
    {
        private readonly DataManager _data;

        public CustomerService(DataManager dataManager)
        {
            this._data = dataManager;
        }



        public Customer Create(Customer customer)
        {
            customer.Id = Guid.NewGuid().ToString();
            return _data.Customers.Create(customer);
        }

        public bool IsRegistered(string id)
        {
            var result = _data.Customers.Get(id);

            return result != null;
        }
    }
}
