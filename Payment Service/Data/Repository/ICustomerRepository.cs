using Payment_Service.Models;

namespace Payment_Service.Data.Repository
{
    public interface ICustomerRepository
    {
        public Customer GetCustomer(Guid customerId);
        public Customer CreateCustomer(Customer customer);

    }
}
