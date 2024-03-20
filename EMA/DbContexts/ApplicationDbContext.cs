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
        public DbSet<AccountRole> AccountRoles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Use Fluent API to map the enum property to a string column
            modelBuilder.Entity<AccountRole>()
                .HasKey(ar => new { ar.AccountEmail, ar.Role });

            modelBuilder.Entity<AccountRole>()
            .Property(e => e.Role)
            .HasConversion<string>(); // Convert enum to string when storing in the database

            // Configure value conversion for ICollection<YourEnum> to ICollection<string>
            modelBuilder.Entity<Account>()
                .Property(e => e.AccountRoles)
                .HasConversion(
                    v => string.Join(',', v.Select(r => r)),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(r => (AccountRole)Enum.Parse(typeof(AccountRole), r)).ToList()
                );

        }
    }
}
