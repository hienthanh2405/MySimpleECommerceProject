using Microsoft.EntityFrameworkCore;
using MySimpleECommerce.Domain.Entities;

namespace MySimpleECommerce.Infrastructure
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<ProductCategories> ProductCategories { get; set; }
        public DbSet<Product> Products { get; set; }

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
