using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addreport1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReportCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReportSubCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportSubCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportSubCategories_ReportCategories_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "ReportCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ReportEntries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SupCategoryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportEntries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportEntries_ReportSubCategories_SupCategoryID",
                        column: x => x.SupCategoryID,
                        principalTable: "ReportSubCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7759), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7772) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7775), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7776) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7777), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7778) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7779), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7781), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7781) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7783), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7784) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7785), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7786) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7787), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7787) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7789), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7789) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7791), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7791) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7793), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7793) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7794), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7795) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7796), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7796) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7798), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7799), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7800) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7801), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7801) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7803), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7803) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7805), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7805) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7806), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7807) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7808), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7809) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7810), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7810) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7811), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7812) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7813), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7813) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7814), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7816), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7816) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7818), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7818) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7819), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7820) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7821), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7821) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7822), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7823) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7829), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7830) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7831), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7833), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7833) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7834), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7835) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7837), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7837) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7838), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7839) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7840), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7840) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7842), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7842) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7843), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7843) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7845), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7845) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7846), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7847) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7848), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7848) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7849), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7850) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7851), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7851) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7853), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7853) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7854), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7855) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7856), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7856) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7857), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7858) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7859), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7859) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7860), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7863), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7863) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7865), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7866) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7867), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7867) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7869), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7869) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7870), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7871) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7872), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7872) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7873), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7874) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7875), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7875) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7876), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7877) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7878), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7878) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7880), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7881), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7882) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7883), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7884), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7885) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7886), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7886) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7887), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7895), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7896) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7897), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7897) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7899), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7900), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7901) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7902), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7903), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7905), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7906), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7907) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7908), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7908) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7910), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7910) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7911), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7912) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7913), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7914), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7915) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7916), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7916) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7917), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7919), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7919) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7921), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7921) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7922), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7923) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7924), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7925), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7926) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7928), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7928) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7929), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7930) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7931), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7931) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7933), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7933) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7934), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7935) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7936), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7936) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7938), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7939), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7940) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7941), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7942), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7943) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7944), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7944) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7945), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7946) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7947), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7948), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7949) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7950), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7951) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7959), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7961) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7962), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7963) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7964), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7964) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7965), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7967), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7967) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7969), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7970), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7972), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7972) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7973), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7975), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7975) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7976), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7977) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7978), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7978) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7980), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7980) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7981), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7982) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7983), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7983) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7984), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7985) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7986), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7986) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7988), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7988) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7989), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7989) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7991), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7991) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7992), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7993) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7994), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7994) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7996), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7996) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7997), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7998) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7999), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(7999) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8000), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8001) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8002), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8003), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8004) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8005), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8005) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8008), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8015), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8015) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8187), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8187) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8192), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8192) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8195), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8194) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8198), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8197) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8201), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8205), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8204) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8207), new DateTime(2025, 6, 29, 8, 37, 37, 246, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.CreateIndex(
                name: "IX_ReportEntries_SupCategoryID",
                table: "ReportEntries",
                column: "SupCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_ReportSubCategories_CategoryID",
                table: "ReportSubCategories",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportEntries");

            migrationBuilder.DropTable(
                name: "ReportSubCategories");

            migrationBuilder.DropTable(
                name: "ReportCategories");

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2083), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2094), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2095), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2097), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2097) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2098), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2100), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2101) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2102), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2103), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2104), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2105) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2106), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2107) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2108), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2109), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2111), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2112), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2113), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2115), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2119), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2121), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2121) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2122), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2123), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2125), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2126), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2127), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2129), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2130), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2132), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2133), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2134), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2135), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2136) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2137), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2138), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2140), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2142), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2144), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2145), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2146), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2148), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2149), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2149) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2150), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2152), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2153), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2153) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2154), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2156), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2157), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2159), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2159) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2160), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2161), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2163), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2164), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2166), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2168), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2169), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2173), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2174), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2175), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2177), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2178), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2179), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2181), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2182), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2182) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2183), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2185), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2186), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2186) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2187), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2189), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2191), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2192), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2194), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2196), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2197), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2198), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2200), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2201), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2202), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2204), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2205), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2206), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2208), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2209), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2210), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2212), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2213), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2215), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2216), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2217), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2219), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2223), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2225), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2227), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2228), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2229), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2231), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2231) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2232), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2233), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2235), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2235) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2236), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2237), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2239), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2240), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2241), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2243), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2243) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2244), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2245), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2248), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2249), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2249) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2250), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2252), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2253), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2254), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2255) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2256), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2257), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2258), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2259) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2260), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2261), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2262), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2264), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2265), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2266), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2267) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2268), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2268) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2269), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2269) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2270), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2271) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2272), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2272) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2273), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2273) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2274), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2276), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2276) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2280), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2281), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2283), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2284), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2286), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2287) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2287), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2434), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2437), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2440), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2442), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2444), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2447), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2449), new DateTime(2025, 6, 29, 8, 16, 18, 735, DateTimeKind.Local).AddTicks(2448) });
        }
    }
}
