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
            db.SaveChanges();
            return customer;
        }

        public Customer Get(string customerId)
        {
            return db.Customers.FirstOrDefault(x=>x.Id == customerId);
        }
    }
}
