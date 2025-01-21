namespace backend.Repository;
using backend.Models;
using Microsoft.EntityFrameworkCore;

public class BookContext : DbContext
{
    public DbSet<Book> Books { get; set; }

    public DbSet<Publisher> Publishers { get; set; }

    public DbSet<Author> Authors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"
                Server=db,1433;
                Database=my_context_db;
                User=SA;
                Password=SenhaForte@123;
                TrustServerCertificate=True;
            ");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Definição da relação com Author
        modelBuilder.Entity<Book>()
            .HasOne(b => b.Author)
            .WithMany(a => a.Books)
            .HasForeignKey(b => b.AuthorId);

        // Definição da relação com Publisher
        modelBuilder.Entity<Book>()
            .HasOne(b => b.Publisher)
            .WithMany(p => p.Books)
            .HasForeignKey(b => b.PublisherId);
    }
}