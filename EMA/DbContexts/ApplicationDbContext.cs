using EMA.Models;
using Microsoft.EntityFrameworkCore;

namespace EMA.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to map the enum property to a string column
            modelBuilder.Entity<Account>()
                .Property(e => e.Role)
                .HasConversion<string>(); // Convert enum to string when storing in the database
        }
    }
}
