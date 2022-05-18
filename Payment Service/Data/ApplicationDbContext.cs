using Microsoft.EntityFrameworkCore;
using Payment_Service.Models;

namespace Payment_Service.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<TransactionPowerApps> Transactions { get; set; }
        public DbSet<TransactionHistory> TransactionHistories { get; set; }

    }
}
