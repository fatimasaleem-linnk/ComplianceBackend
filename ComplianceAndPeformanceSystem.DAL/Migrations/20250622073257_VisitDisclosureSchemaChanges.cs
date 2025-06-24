using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class VisitDisclosureSchemaChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SurveyNotes",
                table: "ComplianceVisitSpecialist");

            migrationBuilder.CreateTable(
                name: "ComplianceVisitDisclosure",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplianceVisitSpecialistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SurveyNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HasConflicts = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_ComplianceVisitDisclosure", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplianceVisitDisclosure_ComplianceVisitSpecialistId",
                        column: x => x.ComplianceVisitSpecialistId,
                        principalTable: "ComplianceVisitSpecialist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1956), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1974) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1977), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1980), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1982), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1984), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1985) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1987), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1989), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1990) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1992), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1994), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1994) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1996), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1997) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1999), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(1999) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2001), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2001) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2003), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2003) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2005), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2005) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2007), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2007) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2009), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2010) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2012), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2013) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2015), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2016) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2017), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2018) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2019), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2020) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2021), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2022) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2023), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2024) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2025), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2026) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2028), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2030), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2036), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2038) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2039), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2041), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2042) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2043), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2045), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2047), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2049), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2051), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2052) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2054), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2058), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2060), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2062), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2062) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2064), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2066), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2068), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2068) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2070), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2072), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2074), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2074) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2076), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2077) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2078), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2080), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2082), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2084), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2085) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2086), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2088), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2090), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2092), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2094), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2097), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2099), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2101), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2104), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2106), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2106) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2108), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2110), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2112), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2114), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2114) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2121), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2124) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2125), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2127), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2130), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2132), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2134), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2136), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2138), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2140), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2143), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2144) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2145), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2146) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2147), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2149), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2152), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2153), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2155), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2156) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2157), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2159), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2161), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2163), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2165), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2167), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2168) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2169), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2171), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2173), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2175), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2178), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2179) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2181), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2183), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2185), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2187), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2189), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2189) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2191), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2191) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2193), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2199), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2202), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2204), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2205) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2206), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2208), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2209) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2210), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2212), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2213) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2214), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2215) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2216), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2218), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2220), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2224), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2224) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2226), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2228), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2230), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2232), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2234), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2236), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2238), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2238) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2240), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2242), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2244), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2246), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2246) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2248), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2248) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2250), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2250) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2252), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2252) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2253), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2254) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2255), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2256) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2257), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2258) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2259), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2260) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2457), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2462), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2461) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2465), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2469), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2472), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2477), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2476) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2480), new DateTime(2025, 6, 22, 10, 32, 56, 729, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceVisitDisclosure_ComplianceVisitSpecialistId",
                table: "ComplianceVisitDisclosure",
                column: "ComplianceVisitSpecialistId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ComplianceVisitDisclosure");

            migrationBuilder.AddColumn<string>(
                name: "SurveyNotes",
                table: "ComplianceVisitSpecialist",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2421), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2437), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2439), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2439) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2440), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2441), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2443), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2443) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2444), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2445), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2446), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2448), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2448) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2449), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2450), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2451) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2452), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2453), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2454), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2455), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2456) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2461), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2463) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2465), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2466), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2466) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2467), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2468), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2469), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2470) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2470), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2472), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2473), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2473) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2474), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2475), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2476), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2477) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2477), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2478) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2479), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2479) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2480), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2481), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2481) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2482), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2482) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2484), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2484) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2485), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2485) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2486), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2486) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2487), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2487) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2489), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2491), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2492), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2492) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2493), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2493) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2494), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2495), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2496), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2497) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2498), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2498) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2499), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2500), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2501), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2502) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2502), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2503) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2504), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2504) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2505), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2505) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2513), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2515), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2516) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2517), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2517) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2518), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2518) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2519), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2519) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2520), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2521), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2522), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2522) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2523), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2524) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2524), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2525) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2526), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2526) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2527), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2528), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2529), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2529) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2531), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2531) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2532), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2533), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2533) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2534), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2534) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2535), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2535) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2536), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2537), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2538) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2539), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2539) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2540), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2541) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2542), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2542) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2543), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2544) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2544), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2545) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2546), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2546) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2547), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2547) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2548), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2549), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2549) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2550), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2550) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2551), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2552) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2552), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2553) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2553), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2554) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2555), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2555) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2561), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2563), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2564) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2565), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2565) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2566), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2566) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2567), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2567) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2568), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2569) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2570), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2570) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2571), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2571) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2572), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2573) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2573), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2574) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2574), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2575) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2576), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2576) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2577), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2578), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2578) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2579), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2579) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2580), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2580) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2581), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2581) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2582), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2583) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2583), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2585), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2585) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2586), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2586) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2587), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2588), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2588) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2589), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2590), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2590) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2591), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2592) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2592), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2593) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2593), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2594) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2595), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2595) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2596), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2596) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2597), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2597) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2598), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2598) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2599), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2599) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2600), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2600) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2601), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2602) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2602), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2603) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2604), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2604) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2605), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2605) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2606), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2606) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2612), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2614) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2733), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2736), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2735) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2739), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2738) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2742), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2741) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2744), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2744) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2747), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2746) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2749), new DateTime(2025, 6, 19, 13, 39, 56, 858, DateTimeKind.Local).AddTicks(2749) });
        }
    }
}
