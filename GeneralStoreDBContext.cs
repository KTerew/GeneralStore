using GeneralStoreAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace GeneralStoreAPI
{
    public class GeneralStoreDBContext : DbContext
    {
        public GeneralStoreDBContext(DbContextOptions<GeneralStoreDBContext> options) : base(options) { }
        public DbSet<Product> Products { get; set;}
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Transaction> Transactions { get; set; } 
    }
}