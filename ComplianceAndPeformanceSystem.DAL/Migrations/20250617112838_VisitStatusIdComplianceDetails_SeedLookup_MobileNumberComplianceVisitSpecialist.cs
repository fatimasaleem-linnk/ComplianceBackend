using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class VisitStatusIdComplianceDetails_SeedLookup_MobileNumberComplianceVisitSpecialist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MobileNumber",
                table: "ComplianceVisitSpecialist",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "VisitStatusId",
                table: "ComplianceDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.InsertData(
                table: "CategoryLookup",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[] { 8L, "حالة الزيارة", "Visit Status" });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2247), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2257) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2260), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2261) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2262), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2262) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2263), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2264) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2265), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2265) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2275), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2276), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2277) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2278), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2278) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2279), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2281), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2282) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2283), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2283) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2284), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2285) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2286), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2286) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2287), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2288) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2289), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2290), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2291) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2292), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2292) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2294), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2294) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2295), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2296) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2297), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2297) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2298), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2299) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2300), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2301), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2301) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2302), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2303) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2304), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2304) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2305), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2306) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2307), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2307) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2308), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2310), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2310) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2311), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2312) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2313), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2313) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2314), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2315) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2316), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2317) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2319), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2319) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2320), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2321) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2322), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2322) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2323), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2324) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2325), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2325) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2326), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2327) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2332), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2336), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2336) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2337), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2337) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2338), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2339) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2340), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2341), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2342) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2343), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2343) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2344), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2345) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2346), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2346) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2347), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2347) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2348), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2349) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2350), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2351) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2352), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2352) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2353), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2354) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2355), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2355) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2356), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2357) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2358), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2358) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2359), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2359) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2360), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2361) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2362), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2362) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2363), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2364) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2365), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2365) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2366), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2367) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2368), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2369), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2370) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2371), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2371) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2374), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2374) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2375), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2375) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2376), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2377) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2378), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2379) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2380), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2381) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2382), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2383), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2383) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2384), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2385) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2389), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2393), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2393) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2394), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2396), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2397), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2399), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2399) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2400), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2400) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2401), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2403), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2403) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2404), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2406), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2406) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2408), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2409) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2410), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2412), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2412) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2415), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2415) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2416), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2416) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2417), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2420) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2421), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2422), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2424), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2424) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2425), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2427), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2427) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2428), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2429), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2430) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2431), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2431) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2432), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2433) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2434), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2434) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2435), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2436) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2437), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2437) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2438), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2438) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2440), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2440) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2441), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2441) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2444), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2446), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2446) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2447), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2448), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2450), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2451), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2453), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2453) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2454), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2454) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2461), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2464) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2465), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2466), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2467) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2468), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2468) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2469), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2469) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2470), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2471) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2472), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2472) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2473), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2474) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2475), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2475) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2627), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2627) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2631), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2631) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2634), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2634) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2637), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2639), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2639) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2642), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2642) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2647), new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2647) });

            migrationBuilder.InsertData(
                table: "LookupValue",
                columns: new[] { "Id", "CategoryId", "CreatedByEmail", "CreatedByID", "CreatedByUserName", "CreatedOn", "IsDeleted", "ModifiedByEmail", "ModifiedByID", "ModifiedByUserName", "ModifiedOn", "ValueAr", "ValueEn" },
                values: new object[,]
                {
                    { 123L, 8L, null, null, null, new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2476), null, null, null, null, new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2476), "مجدولة", "Scheduled" },
                    { 124L, 8L, null, null, null, new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2477), null, null, null, null, new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2478), "تمت إعادة جدولة", "Rescheduled" },
                    { 125L, 8L, null, null, null, new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2479), null, null, null, null, new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2479), "الإفصاح عن تضارب المصالح", "Conflict Of Interest Disclosure" },
                    { 126L, 8L, null, null, null, new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2480), null, null, null, null, new DateTime(2025, 6, 17, 14, 28, 37, 780, DateTimeKind.Local).AddTicks(2481), "جديد", "New" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceDetails_VisitStatusId",
                table: "ComplianceDetails",
                column: "VisitStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComplianceDetails_LookupValue_VisitStatusId",
                table: "ComplianceDetails",
                column: "VisitStatusId",
                principalTable: "LookupValue",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComplianceDetails_LookupValue_VisitStatusId",
                table: "ComplianceDetails");

            migrationBuilder.DropIndex(
                name: "IX_ComplianceDetails_VisitStatusId",
                table: "ComplianceDetails");

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L);

            migrationBuilder.DeleteData(
                table: "CategoryLookup",
                keyColumn: "Id",
                keyValue: 8L);

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "ComplianceVisitSpecialist");

            migrationBuilder.DropColumn(
                name: "VisitStatusId",
                table: "ComplianceDetails");

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(137), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(147) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(150), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(152), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(153), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(154) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(155), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(157), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(158) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(159), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(160), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(161) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(162), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(164), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(164) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(166), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(167), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(168) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(169), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(170), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(171) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(172), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(173), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(174) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(175), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(175) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(177), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(178) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(179), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(179) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(180), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(181) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(182), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(182) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(183), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(184) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(185), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(185) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(186), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(187) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(188), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(189) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(190), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(191), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(192) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(193), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(193) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(194), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(195) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(196), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(196) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(197), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(198) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(199), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(200), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(201) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(203), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(203) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(204), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(205) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(208), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(209) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(210), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(210) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(211), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(213), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(213) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(214), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(215) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(216), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(217), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(218) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(219), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(219) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(220), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(222), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(224), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(224) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(225), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(225) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(227), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(227) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(228), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(228) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(230), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(230) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(231), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(232) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(233), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(233) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(234), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(235) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(236), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(236) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(237), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(239), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(239) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(240), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(241) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(242), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(242) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(243), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(244) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(245), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(245) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(246), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(247) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(248), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(248) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(250), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(250) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(251), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(252) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(253), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(253) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(255), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(255) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(256), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(257) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(258), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(258) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(260), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(260) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(261), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(262) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(263), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(263) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(266), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(267) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(268), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(268) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(269), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(270) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(271), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(271) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(272), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(274), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(275), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(277), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(278), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(280), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(280) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(281), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(282) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(283), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(283) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(284), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(285) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(286), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(286) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(287), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(289), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(289) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(291), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(292), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(293) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(294), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(295), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(296) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(297), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(298), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(299) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(300), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(300) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(301), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(303), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(303) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(304), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(305) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(306), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(306) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(308), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(308) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(309), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(309) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(311), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(311) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(312), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(313) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(314), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(314) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(315), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(316) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(317), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(317) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(318), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(319) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(320), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(320) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(321), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(322) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(323), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(323) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(324), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(325) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(326), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(326) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(327), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(328) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(331), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(332) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(333), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(333) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(334), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(335) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(336), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(336) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(337), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(339), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(339) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(340), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(341) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(342), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(342) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(343), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(344) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(345), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(480), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(479) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(483), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(483) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(486), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(485) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(488), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(488) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(491), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(490) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(494), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(493) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(496), new DateTime(2025, 6, 12, 13, 12, 10, 950, DateTimeKind.Local).AddTicks(495) });
        }
    }
}
