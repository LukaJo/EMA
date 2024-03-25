using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EMA.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationsBetweenEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "SkillAssessment",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "SkillAssessmentId",
                table: "Skill",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 14, 3, 33, 764, DateTimeKind.Utc).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 14, 3, 33, 764, DateTimeKind.Utc).AddTicks(8423));

            migrationBuilder.UpdateData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 14, 3, 33, 764, DateTimeKind.Utc).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 14, 3, 33, 764, DateTimeKind.Utc).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "SkillType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 14, 3, 33, 764, DateTimeKind.Utc).AddTicks(9408));

            migrationBuilder.UpdateData(
                table: "SkillType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 14, 3, 33, 764, DateTimeKind.Utc).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "SkillType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 14, 3, 33, 764, DateTimeKind.Utc).AddTicks(9435));

            migrationBuilder.UpdateData(
                table: "SkillType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 14, 3, 33, 764, DateTimeKind.Utc).AddTicks(9443));

            migrationBuilder.UpdateData(
                table: "SkillType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 14, 3, 33, 764, DateTimeKind.Utc).AddTicks(9451));

            migrationBuilder.CreateIndex(
                name: "IX_SkillAssessment_Email",
                table: "SkillAssessment",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_Skill_SkillAssessmentId",
                table: "Skill",
                column: "SkillAssessmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skill_SkillAssessment_SkillAssessmentId",
                table: "Skill",
                column: "SkillAssessmentId",
                principalTable: "SkillAssessment",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SkillAssessment_Employee_Email",
                table: "SkillAssessment",
                column: "Email",
                principalTable: "Employee",
                principalColumn: "Email",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skill_SkillAssessment_SkillAssessmentId",
                table: "Skill");

            migrationBuilder.DropForeignKey(
                name: "FK_SkillAssessment_Employee_Email",
                table: "SkillAssessment");

            migrationBuilder.DropIndex(
                name: "IX_SkillAssessment_Email",
                table: "SkillAssessment");

            migrationBuilder.DropIndex(
                name: "IX_Skill_SkillAssessmentId",
                table: "Skill");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "SkillAssessment");

            migrationBuilder.DropColumn(
                name: "SkillAssessmentId",
                table: "Skill");

            migrationBuilder.UpdateData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "SkillCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "SkillType",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2579));

            migrationBuilder.UpdateData(
                table: "SkillType",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "SkillType",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2585));

            migrationBuilder.UpdateData(
                table: "SkillType",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "SkillType",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 3, 25, 11, 35, 2, 20, DateTimeKind.Utc).AddTicks(2588));
        }
    }
}
