using Payment_Service.Models;

namespace Payment_Service.Data.Repository
{
    public interface ICustomerRepository
    {
        public Customer Get(string customerId);
        public Customer Create(Customer customer);

    }
}
