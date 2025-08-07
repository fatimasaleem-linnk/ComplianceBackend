using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class EditCorrectPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CorrectiveEvidences_CorrectiveActionPlans_CorrectiveActionPlanId",
                table: "CorrectiveEvidences");

            migrationBuilder.DropIndex(
                name: "IX_CorrectiveEvidences_CorrectiveActionPlanId",
                table: "CorrectiveEvidences");

            migrationBuilder.DropColumn(
                name: "CorrectiveActionPlanId",
                table: "CorrectiveEvidences");

            migrationBuilder.RenameColumn(
                name: "ComplianceReportId",
                table: "CorrectiveActionPlans",
                newName: "ReportId");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "CorrectiveEvidences",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CorrectiveActionPlans",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<long>(
                name: "LicenseEntityID",
                table: "CorrectiveActionPlans",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_CorrectiveEvidences_PlanId",
                table: "CorrectiveEvidences",
                column: "PlanId");

            migrationBuilder.CreateIndex(
                name: "IX_CorrectiveActionPlans_ReportId",
                table: "CorrectiveActionPlans",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrectiveActionPlans_ComplianceReports_ReportId",
                table: "CorrectiveActionPlans",
                column: "ReportId",
                principalTable: "ComplianceReports",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CorrectiveEvidences_CorrectiveActionPlans_PlanId",
                table: "CorrectiveEvidences",
                column: "PlanId",
                principalTable: "CorrectiveActionPlans",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CorrectiveActionPlans_ComplianceReports_ReportId",
                table: "CorrectiveActionPlans");

            migrationBuilder.DropForeignKey(
                name: "FK_CorrectiveEvidences_CorrectiveActionPlans_PlanId",
                table: "CorrectiveEvidences");

            migrationBuilder.DropIndex(
                name: "IX_CorrectiveEvidences_PlanId",
                table: "CorrectiveEvidences");

            migrationBuilder.DropIndex(
                name: "IX_CorrectiveActionPlans_ReportId",
                table: "CorrectiveActionPlans");

            migrationBuilder.DropColumn(
                name: "LicenseEntityID",
                table: "CorrectiveActionPlans");

            migrationBuilder.RenameColumn(
                name: "ReportId",
                table: "CorrectiveActionPlans",
                newName: "ComplianceReportId");

            migrationBuilder.AlterColumn<string>(
                name: "Comments",
                table: "CorrectiveEvidences",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CorrectiveActionPlanId",
                table: "CorrectiveEvidences",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CorrectiveActionPlans",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CorrectiveEvidences_CorrectiveActionPlanId",
                table: "CorrectiveEvidences",
                column: "CorrectiveActionPlanId");

            migrationBuilder.AddForeignKey(
                name: "FK_CorrectiveEvidences_CorrectiveActionPlans_CorrectiveActionPlanId",
                table: "CorrectiveEvidences",
                column: "CorrectiveActionPlanId",
                principalTable: "CorrectiveActionPlans",
                principalColumn: "Id");
        }
    }
}
