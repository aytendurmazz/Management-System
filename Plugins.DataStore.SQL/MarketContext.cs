using CoreBusiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasData(
                    new Product { ProductId = 1, Name = "Iced Tea", Quantity = 100, Price = 1.99 },
                    new Product { ProductId = 2, Name = "Canada Dry", Quantity = 200, Price = 1.99 },
                    new Product { ProductId = 3, Name = "Whole Wheat Bread", Quantity = 300, Price = 1.50 },
                    new Product { ProductId = 4, Name = "White Bread", Quantity = 300, Price = 1.50 }
                );
        }
    }
}
