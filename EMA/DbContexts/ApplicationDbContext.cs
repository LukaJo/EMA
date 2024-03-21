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
        public DbSet<Employee> Employees { get; set; }
        public DbSet<SkillAssessment> SkillAssessments { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent API
            #region Account-Role
            //Configures AccountEmail and Role as the composite key(foreign keys must be the composite primary key in the joining table)
            modelBuilder.Entity<AccountRole>()
                        .HasKey(ar => new { ar.AccountEmail, ar.Role });

            ////Set up the many-to-many relationship(with this code Role column is not present in Table Account)
            //modelBuilder.Entity<AccountRole>()
            //            .HasOne<Account>(ar => ar.Account)
            //            .WithMany(a => a.AccountRoles)
            //            .HasForeignKey(ar => ar.AccountEmail);

            //Convert enum to string when storing in the database(by default is int)
            modelBuilder.Entity<AccountRole>()
                        .Property(e => e.Role)
                        .HasConversion<string>();

            //Configure value conversion for List<AccountRole> to List<string> inside Table Account for column Role(with this code Role column is present in Table Account)
            modelBuilder.Entity<Account>()
                        .Property(e => e.AccountRoles)
                        .HasConversion(
                            v => string.Join(',', v.Select(r => r)),
                            v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(r => (AccountRole)Enum.Parse(typeof(AccountRole), r)).ToList()
                        );
            #endregion

            #region SkillAssessment
            // Configure the one-to-one relationship with SkillAssessmentStatus
            modelBuilder.Entity<SkillAssessment>()
                .Property(sa => sa.SkillAssessmentStatus)
                .HasConversion<string>();
            #endregion


        }
    }
}
