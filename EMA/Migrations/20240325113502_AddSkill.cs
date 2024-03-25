using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EMA.Migrations
{
    /// <inheritdoc />
    public partial class AddSkill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkillCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Ordering = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkillType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<string>(type: "text", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    IsActive = table.Column<bool>(type: "boolean", nullable: false),
                    ModifiedBy = table.Column<string>(type: "text", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Ordering = table.Column<int>(type: "integer", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    SkillCategoryId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkillType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SkillType_SkillCategory_SkillCategoryId",
                        column: x => x.SkillCategoryId,
                        principalTable: "SkillCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Skill",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EmployeesOppinionUpdatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    ManagersOppinionUpdatedTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SkillExperience = table.Column<string>(type: "text", nullable: true),
                    SkillExperienceDuration = table.Column<double>(type: "double precision", nullable: false),
                    OtherSkillType = table.Column<string>(type: "text", nullable: true),
                    SkillLevelManagersOppinion = table.Column<string>(type: "text", nullable: false),
                    SkillLevelEmployeesOppinion = table.Column<string>(type: "text", nullable: false),
                    SkillTypeId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Skill_SkillType_SkillTypeId",
                        column: x => x.SkillTypeId,
                        principalTable: "SkillType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SkillCategory",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsActive", "ModifiedBy", "ModifiedDate", "Ordering", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2422), null, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Programming Languages" },
                    { 2, null, new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2426), null, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "BE_Frameworks" },
                    { 3, null, new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2427), null, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "FE_Frameworks" },
                    { 4, null, new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2428), null, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Other" }
                });

            migrationBuilder.InsertData(
                table: "SkillType",
                columns: new[] { "Id", "CreatedBy", "CreatedDate", "Description", "IsActive", "ModifiedBy", "ModifiedDate", "Ordering", "SkillCategoryId", "Value" },
                values: new object[,]
                {
                    { 1, null, new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2579), null, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Java" },
                    { 2, null, new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2584), null, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1, "Javascript" },
                    { 3, null, new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2585), null, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2, "dotNET" },
                    { 4, null, new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2587), null, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 1, "C#" },
                    { 5, null, new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2588), null, true, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4, "Other" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skill_SkillTypeId",
                table: "Skill",
                column: "SkillTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SkillType_SkillCategoryId",
                table: "SkillType",
                column: "SkillCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skill");

            migrationBuilder.DropTable(
                name: "SkillType");

            migrationBuilder.DropTable(
                name: "SkillCategory");
        }
    }
}
