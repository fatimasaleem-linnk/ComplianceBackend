using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addreport4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ComplianceReports",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VisitType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Licensee = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FacilityOrLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Activity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InspectionScope = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseGovernorate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LicenseId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CommercialOperationDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LicenseIssueDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Recommendation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_ComplianceReports", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Auditors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auditors", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Auditors_ComplianceReports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "ComplianceReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LicenseParticipants",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicenseParticipants", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LicenseParticipants_ComplianceReports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "ComplianceReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PreviousRecommendations",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletionStatusID = table.Column<int>(type: "int", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousRecommendations", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PreviousRecommendations_ComplianceReports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "ComplianceReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questaions",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryID = table.Column<int>(type: "int", nullable: true),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubCategoryID = table.Column<int>(type: "int", nullable: true),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntryID = table.Column<int>(type: "int", nullable: true),
                    EntryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Grade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Evidence = table.Column<bool>(type: "bit", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReportID = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questaions", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Questaions_ComplianceReports_ReportID",
                        column: x => x.ReportID,
                        principalTable: "ComplianceReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7885), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7898), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7900), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7902), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7903), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7905), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7906), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7908), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7909), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7909) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7911), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7913), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7914), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7914) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7915), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7917), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7917) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7918), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7919), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7920) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7921), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7928), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7930), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7931), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7932), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7934), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7934) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7935), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7936), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7937) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7938), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7939), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7939) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7940), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7942), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7942) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7943), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7944), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7945) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7945), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7947), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7948), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7948) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7950), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7950) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7951), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7952) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7953), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7953) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7954), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7954) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7955), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7956) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7957), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7957) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7958), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7959), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7961), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7962), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7962) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7964), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7965), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7967), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7968), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7969), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7970) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7971), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7972), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7973), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7975), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7980), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7981) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7982), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7983), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7984), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7985), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7987), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7987) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7988), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7989), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7991), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7993), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7994), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7995) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7996), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7997), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7997) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7999), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8000), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8001), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8003), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8003) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8004), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8005), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8006) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8007), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8007) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8008), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8009), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8010) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8011), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8011) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8012), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8012) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8013), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8014) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8015), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8016), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8016) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8018), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8018) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8019), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8020) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8021), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8021) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8022), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8022) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8023), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8024) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8025), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8025) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8026), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8031), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8031) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8032), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8033) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8034), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8034) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8035), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8036), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8037) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8038), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8038) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8039), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8039) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8040), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8041) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8042), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8043), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8043) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8044), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8045) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8047), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8047) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8048), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8048) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8049), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8050) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8051), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8052), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8052) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8053), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8053) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8054), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8055) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8056), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8056) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8057), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8057) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8058), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8060), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8060) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8061), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8061) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8062), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8063) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8064), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8064) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8065), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8066), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8067) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8068), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8068) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8069), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8069) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8070), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8070) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8071), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8072) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8073), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8073) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8074), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8075), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8076) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8077), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8077) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8078), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8078) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8079), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8081), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8081) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8082), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8082) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8083), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8084) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8089), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8089) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8090), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8091) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8092), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8094), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8095), new DateTime(2025, 6, 29, 12, 1, 31, 915, DateTimeKind.Local).AddTicks(8096) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(414), new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(410) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(418), new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(421), new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(420) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(425), new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(425) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(428), new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(428) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(432), new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(432) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(435), new DateTime(2025, 6, 29, 12, 1, 31, 916, DateTimeKind.Local).AddTicks(434) });

            migrationBuilder.CreateIndex(
                name: "IX_Auditors_ReportID",
                table: "Auditors",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_LicenseParticipants_ReportID",
                table: "LicenseParticipants",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousRecommendations_ReportID",
                table: "PreviousRecommendations",
                column: "ReportID");

            migrationBuilder.CreateIndex(
                name: "IX_Questaions_ReportID",
                table: "Questaions",
                column: "ReportID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auditors");

            migrationBuilder.DropTable(
                name: "LicenseParticipants");

            migrationBuilder.DropTable(
                name: "PreviousRecommendations");

            migrationBuilder.DropTable(
                name: "Questaions");

            migrationBuilder.DropTable(
                name: "ComplianceReports");

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(749), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(758) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(760), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(761) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(762), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(763) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(764), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(765), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(765) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(767), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(768) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(768), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(769) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(770), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(770) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(771), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(771) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(773), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(774), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(775), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(775) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(776), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(778), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(778) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(779), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(779) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(780), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(781) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(781), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(782) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(784), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(785), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(786) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(787), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(787) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(788), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(788) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(789), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(789) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(790), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(792), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(792) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(793), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(793) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(798), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(799) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(800), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(800) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(801), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(801) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(802), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(802) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(803), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(804) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(805), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(805) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(806), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(806) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(807), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(807) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(809), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(810), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(811), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(812) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(813), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(813) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(814), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(814) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(815), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(815) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(816), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(817), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(818) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(819), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(819) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(820), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(820) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(821), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(821) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(822), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(823), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(824) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(825), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(826), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(827), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(827) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(828), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(829) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(829), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(831), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(832), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(834), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(834) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(835), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(835) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(836), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(838), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(838) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(839), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(839) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(840), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(841), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(842), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(848), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(850), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(850) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(851), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(852), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(853) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(854), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(854) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(855), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(856) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(856), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(857) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(858), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(859), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(859) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(860), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(862), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(862) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(863), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(863) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(864), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(866), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(866) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(867), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(867) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(868), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(869), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(870), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(871) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(871), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(872) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(873), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(874), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(874) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(875), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(875) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(876), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(877) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(877), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(878) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(879), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(879) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(880), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(880) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(881), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(881) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(882), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(885), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(885) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(886), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(886) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(887), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(887) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(888), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(889) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(890), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(890) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(891), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(891) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(892), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(892) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(896), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(897) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(898), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(898) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(899), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(899) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(900), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(901) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(901), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(902) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(903), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(903) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(904), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(904) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(905), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(905) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(906), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(907) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(907), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(908) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(909), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(909) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(911), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(912), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(912) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(913), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(913) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(914), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(915) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(915), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(917), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(917) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(918), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(919), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(919) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(920), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(921) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(921), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(922) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(923), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(924), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(924) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(925), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(925) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(926), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(926) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(927), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(928) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(929), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(929) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(930), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(930) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(931), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(931) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(932), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(932) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(933), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(934) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(934), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(935) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(936), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(936) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(941), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(941) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(942), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(942) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(2990), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(2987) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(2994), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(2993) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(2996), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(2999), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(2999) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(3001), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(3004), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(3004) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(3006), new DateTime(2025, 6, 29, 10, 52, 38, 732, DateTimeKind.Local).AddTicks(3006) });
        }
    }
}
