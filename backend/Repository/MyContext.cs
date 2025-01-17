using Microsoft.EntityFrameworkCore;
namespace backend;

public class MyContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(@"
                Server=db,1433;
                Database=my_context_db;
                User=SA;
                Password=SenhaForte@123;
                TrustServerCertificate=True;
            ");
        }
    }
}
