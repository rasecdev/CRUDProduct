using CRUDProduct.Domain.Entities;
using CRUDProduct.Infra.Maps;
using Microsoft.EntityFrameworkCore;

namespace CRUDProduct.Infra.Data
{
    public class SqlContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
            //Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=CRUDProduct;User ID=SA;Password=SQLS3rv3r");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProductMap());
            builder.ApplyConfiguration(new CategoryMap());
        }
    }
}