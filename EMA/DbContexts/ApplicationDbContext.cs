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
        public DbSet<Skill> Skills { get; set; }
        public DbSet<SkillType> SkillTypes { get; set; }
        public DbSet<SkillCategory> SkillCategories { get; set; }


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

            #region Skill

            // Configure the one-to-one relationship with SkillLevel
            modelBuilder.Entity<Skill>()
                        .Property(s => s.SkillLevelManagersOppinion)
                        .HasConversion<string>();

            modelBuilder.Entity<Skill>()
                        .Property(s => s.SkillLevelEmployeesOppinion)
                        .HasConversion<string>();

            // Define relationship between Skill and SkillType
            modelBuilder.Entity<Skill>()
                .HasOne(s => s.SkillType) // Skill has one SkillType
                .WithMany(st => st.Skills) // SkillType can have many Skills
                .HasForeignKey(s => s.SkillTypeId); // Foreign key property in Skill

            // Define relationship between SkillType and SkillCategory
            modelBuilder.Entity<SkillType>()
                .HasOne(st => st.SkillCategory) // SkillType has one SkillCategory
                .WithMany(sc => sc.SkillTypes) // SkillCategory has many SkillTypes
                .HasForeignKey(st => st.SkillCategoryId); // Foreign key property in SkillType

            // Define relationship between SkillCategory and SkillType
            modelBuilder.Entity<SkillCategory>()
                .HasMany(sc => sc.SkillTypes) // SkillCategory can have many SkillTypes
                .WithOne(st => st.SkillCategory) // SkillType has one SkillCategory
                .HasForeignKey(st => st.SkillCategoryId); // Foreign key property in SkillType
            #endregion

            #region Seed
            // Seed data for SkillCategory
            modelBuilder.Entity<SkillCategory>().HasData(
                new SkillCategory
                {
                    SkillCategoryId = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    Ordering = 1,
                    Value = "Programming Languages"
                },
                new SkillCategory
                {
                    SkillCategoryId = 2,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    Ordering = 2,
                    Value = "BE_Frameworks"
                },
                new SkillCategory
                {
                    SkillCategoryId = 3,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    Ordering = 3,
                    Value = "FE_Frameworks"
                },
                new SkillCategory
                {
                    SkillCategoryId = 4,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    Ordering = 4,
                    Value = "Other"
                }
            );

            // Seed data for SkillType
            modelBuilder.Entity<SkillType>().HasData(
                new SkillType
                {
                    SkillTypeId = 1,
                    SkillCategoryId = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    Ordering = 1,
                    Value = "Java"
                },
                new SkillType
                {
                    SkillTypeId = 2,
                    SkillCategoryId = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    Ordering = 2,
                    Value = "Javascript"
                },
                new SkillType
                {
                    SkillTypeId = 3,
                    SkillCategoryId = 2,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    Ordering = 3,
                    Value = "dotNET"
                },
                new SkillType
                {
                    SkillTypeId = 4,
                    SkillCategoryId = 1,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    Ordering = 4,
                    Value = "C#"
                },
                new SkillType
                {
                    SkillTypeId = 5,
                    SkillCategoryId = 4,
                    CreatedDate = DateTime.UtcNow,
                    IsActive = true,
                    Ordering = 5,
                    Value = "Other"
                }
            );

            #endregion

        }
    }
}
