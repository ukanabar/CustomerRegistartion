using Microsoft.EntityFrameworkCore;

namespace CustomerRegistration.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions<CustomerContext> options) : base(options)
        {

        }
        public DbSet<Customer> customer { get; set; }
    }
}
