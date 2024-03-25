﻿// <auto-generated />
using System;
using EMA.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EMA.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EMA.Models.Account", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("AccountRoles")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("Role");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Matricola")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("EMA.Models.AccountRole", b =>
                {
                    b.Property<string>("AccountEmail")
                        .HasColumnType("text");

                    b.Property<string>("Role")
                        .HasColumnType("text");

                    b.HasKey("AccountEmail", "Role");

                    b.ToTable("AccountRole");
                });

            modelBuilder.Entity("EMA.Models.Employee", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Matricola")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TechnicalManager")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telephone")
                        .HasColumnType("text");

                    b.HasKey("Email");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("EMA.Models.Skill", b =>
                {
                    b.Property<int>("SkillId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SkillId"));

                    b.Property<DateTime>("EmployeesOppinionUpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ManagersOppinionUpdatedTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("OtherSkillType")
                        .HasColumnType("text");

                    b.Property<string>("SkillExperience")
                        .HasColumnType("text");

                    b.Property<double>("SkillExperienceDuration")
                        .HasColumnType("double precision");

                    b.Property<string>("SkillLevelEmployeesOppinion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("SkillLevelManagersOppinion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SkillTypeId")
                        .HasColumnType("integer");

                    b.HasKey("SkillId");

                    b.HasIndex("SkillTypeId");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("EMA.Models.SkillAssessment", b =>
                {
                    b.Property<int>("SkillAssessmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SkillAssessmentId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Feedback")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Note")
                        .HasColumnType("text");

                    b.Property<string>("SkillAssessmentStatus")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SkillAssessmentId");

                    b.ToTable("SkillAssessment");
                });

            modelBuilder.Entity("EMA.Models.SkillCategory", b =>
                {
                    b.Property<int>("SkillCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SkillCategoryId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Ordering")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SkillCategoryId");

                    b.ToTable("SkillCategory");

                    b.HasData(
                        new
                        {
                            SkillCategoryId = 1,
                            CreatedDate = new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2422),
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ordering = 1,
                            Value = "Programming Languages"
                        },
                        new
                        {
                            SkillCategoryId = 2,
                            CreatedDate = new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2426),
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ordering = 2,
                            Value = "BE_Frameworks"
                        },
                        new
                        {
                            SkillCategoryId = 3,
                            CreatedDate = new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2427),
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ordering = 3,
                            Value = "FE_Frameworks"
                        },
                        new
                        {
                            SkillCategoryId = 4,
                            CreatedDate = new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2428),
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ordering = 4,
                            Value = "Other"
                        });
                });

            modelBuilder.Entity("EMA.Models.SkillType", b =>
                {
                    b.Property<int>("SkillTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SkillTypeId"));

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Ordering")
                        .HasColumnType("integer");

                    b.Property<int>("SkillCategoryId")
                        .HasColumnType("integer");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("SkillTypeId");

                    b.HasIndex("SkillCategoryId");

                    b.ToTable("SkillType");

                    b.HasData(
                        new
                        {
                            SkillTypeId = 1,
                            CreatedDate = new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2579),
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ordering = 1,
                            SkillCategoryId = 1,
                            Value = "Java"
                        },
                        new
                        {
                            SkillTypeId = 2,
                            CreatedDate = new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2584),
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ordering = 2,
                            SkillCategoryId = 1,
                            Value = "Javascript"
                        },
                        new
                        {
                            SkillTypeId = 3,
                            CreatedDate = new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2585),
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ordering = 3,
                            SkillCategoryId = 2,
                            Value = "dotNET"
                        },
                        new
                        {
                            SkillTypeId = 4,
                            CreatedDate = new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2587),
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ordering = 4,
                            SkillCategoryId = 1,
                            Value = "C#"
                        },
                        new
                        {
                            SkillTypeId = 5,
                            CreatedDate = new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2588),
                            IsActive = true,
                            ModifiedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Ordering = 5,
                            SkillCategoryId = 4,
                            Value = "Other"
                        });
                });

            modelBuilder.Entity("EMA.Models.AccountRole", b =>
                {
                    b.HasOne("EMA.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("EMA.Models.Skill", b =>
                {
                    b.HasOne("EMA.Models.SkillType", "SkillType")
                        .WithMany("Skills")
                        .HasForeignKey("SkillTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SkillType");
                });

            modelBuilder.Entity("EMA.Models.SkillType", b =>
                {
                    b.HasOne("EMA.Models.SkillCategory", "SkillCategory")
                        .WithMany("SkillTypes")
                        .HasForeignKey("SkillCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SkillCategory");
                });

            modelBuilder.Entity("EMA.Models.SkillCategory", b =>
                {
                    b.Navigation("SkillTypes");
                });

            modelBuilder.Entity("EMA.Models.SkillType", b =>
                {
                    b.Navigation("Skills");
                });
#pragma warning restore 612, 618
        }
    }
}
