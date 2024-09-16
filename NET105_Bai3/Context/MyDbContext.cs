using Microsoft.EntityFrameworkCore;
using NET105_Bai3.Models;

namespace NET105_Bai3.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
