using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class ReportActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_PreviousRecommendations_ReportID",
                table: "PreviousRecommendations");


            migrationBuilder.RenameColumn(
                name: "LicenseId",
                table: "ComplianceReports",
                newName: "LicenseID");


            migrationBuilder.AlterColumn<long>(
                name: "LicenseID",
                table: "ComplianceReports",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");


            migrationBuilder.CreateTable(
                name: "ReportActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsReply = table.Column<bool>(type: "bit", nullable: false),
                    ReplyComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportActivities_ComplianceReports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "ComplianceReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });


            migrationBuilder.InsertData(
                table: "LookupValue",
                columns: new[] { "Id", "CategoryId", "CreatedByEmail", "CreatedByID", "CreatedByUserName", "CreatedOn", "IsDeleted", "ModifiedByEmail", "ModifiedByID", "ModifiedByUserName", "ModifiedOn", "ValueAr", "ValueEn" },
                values: new object[,]
                {
                    { 139L, 9L, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مرفقات التقارير", "ReportAttachment" },
                });

            migrationBuilder.CreateIndex(
                name: "IX_PreviousRecommendations_ReportID",
                table: "PreviousRecommendations",
                column: "ReportID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReportActivities_ReportId",
                table: "ReportActivities",
                column: "ReportId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportActivities");

            migrationBuilder.DropIndex(
                name: "IX_PreviousRecommendations_ReportID",
                table: "PreviousRecommendations");

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 135L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 136L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 137L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 138L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 139L);

            migrationBuilder.DeleteData(
                table: "CategoryLookup",
                keyColumn: "Id",
                keyValue: 10L);

            migrationBuilder.DeleteData(
                table: "CategoryLookup",
                keyColumn: "Id",
                keyValue: 11L);

            migrationBuilder.DropColumn(
                name: "LocationID",
                table: "ComplianceReports");

            migrationBuilder.DropColumn(
                name: "ReportTypeID",
                table: "ComplianceReports");

            migrationBuilder.DropColumn(
                name: "VisitTypeID",
                table: "ComplianceReports");

            migrationBuilder.DropColumn(
                name: "AuditorID",
                table: "Auditors");

            migrationBuilder.RenameColumn(
                name: "LicenseID",
                table: "ComplianceReports",
                newName: "LicenseId");

            migrationBuilder.RenameColumn(
                name: "LicenseNumber",
                table: "ComplianceReports",
                newName: "VisitType");

            migrationBuilder.AlterColumn<string>(
                name: "LicenseId",
                table: "ComplianceReports",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddColumn<string>(
                name: "LicenseGovernorate",
                table: "ComplianceReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Licensee",
                table: "ComplianceReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ReportType",
                table: "ComplianceReports",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousRecommendations_ReportID",
                table: "PreviousRecommendations",
                column: "ReportID");
        }
    }
}
