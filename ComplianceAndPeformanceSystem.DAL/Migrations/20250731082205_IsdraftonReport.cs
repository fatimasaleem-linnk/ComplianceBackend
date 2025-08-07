using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class IsdraftonReport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDraft",
                table: "ComplianceReports",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReportStatusID",
                table: "ComplianceReports",
                type: "int",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDraft",
                table: "ComplianceReports");

            migrationBuilder.DropColumn(
                name: "ReportStatusID",
                table: "ComplianceReports");
        }
    }
}
