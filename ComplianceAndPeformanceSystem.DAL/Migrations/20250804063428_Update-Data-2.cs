using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageType",
                value: "warning");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageType",
                value: "warning");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageType",
                value: "info");
        }
    }
}
