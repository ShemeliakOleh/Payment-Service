using Payment_Service.Data.Repository;
using Payment_Service.Models;

namespace Payment_Service.Data.RepositoryImpl
{
    public class CustomerRepository : BaseRepository,ICustomerRepository
    {
        public CustomerRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }

        public Customer Create(Customer customer)
        {
           db.Customers.Add(customer);
            return customer;
        }

        public Customer Get(Guid customerId)
        {
            throw new NotImplementedException();
        }
    }
}
