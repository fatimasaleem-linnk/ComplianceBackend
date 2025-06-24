using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class VisitStatusesLookupSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 29,
                column: "Role",
                value: "ComplianceSpecialist");

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5040), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5053) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5056), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5058), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5058) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5059), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5061), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5063), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5064) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5065), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5065) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5068), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5068) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5069), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5071), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5073), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5073) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5075), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5076), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5082), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5084), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5085) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5086), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5088), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5090), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5090) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5091), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5093), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5093) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5094), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5096), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5096) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5097), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5099), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5099) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5100), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5101) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5105), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5107), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5107) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5108), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5110), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5110) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5111), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5113), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5113) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5114), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5115) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5116), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5118), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5118) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5120), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5120) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5121), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5122) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5123), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5124), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5126), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5126) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5127), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5128) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5129), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5129) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5130), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5132), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5132) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5134), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5134) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5136), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5137), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5138) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5139), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5139) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5140), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5141) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5142), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5142) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5148), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5149) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5150), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5151) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5152), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5152) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5153), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5154) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5155), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5155) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5156), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5157) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5158), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5158) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5159), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5160) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5161), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5161) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5162), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5164), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5164) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5165), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5166) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5168), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5168) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5169), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5170) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5171), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5171) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5172), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5173) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5175), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5175) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5176), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5178), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5179), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5180) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5181), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5181) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5182), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5183) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5184), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5184) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5186), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5186) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5187), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5187) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5189), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5189) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5190), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5190) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5192), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5192) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5193), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5193) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5195), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5195) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5197), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5197) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5198), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5199) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5200), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5200) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5202), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5202) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5208), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5209) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5210), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5210) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5212), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5212) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5213), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5214) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5215), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5215) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5216), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5217) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5218), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5219), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5220) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5221), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5221) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5222), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5223) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5224), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5224) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5225), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5227), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5227) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5228), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5229) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5231), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5231) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5232), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5233) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5234), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5234) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5235), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5236) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5237), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5237) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5238), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5239) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5240), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5240) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5241), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5242) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5243), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5244), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5245) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5246), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5246) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5248), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5248) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5249), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5249) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5250), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5251) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5252), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5254), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5254) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5255), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5256) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5257), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5258), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5259) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5260), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5261), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5263), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5263) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5264), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5265) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5266), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5267), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5269), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5269) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5275), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5277) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5278), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5279), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5280) });

            migrationBuilder.InsertData(
                table: "LookupValue",
                columns: new[] { "Id", "CategoryId", "CreatedByEmail", "CreatedByID", "CreatedByUserName", "CreatedOn", "IsDeleted", "ModifiedByEmail", "ModifiedByID", "ModifiedByUserName", "ModifiedOn", "ValueAr", "ValueEn" },
                values: new object[,]
                {
                    { 130L, 8L, null, null, null, new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5281), null, null, null, null, new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5281), "تم حل تضارب المصالح", "Conflict Of Interest Resolved" },
                    { 131L, 8L, null, null, null, new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5282), null, null, null, null, new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5283), "لا يوجد عضو فريق متاح", "No Team Member Available" }
                });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5431), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5430) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5435), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5434) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5437), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5440), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5440) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5443), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5442) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5446), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5446) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5448), new DateTime(2025, 6, 24, 14, 40, 9, 536, DateTimeKind.Local).AddTicks(5448) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 29,
                column: "Role",
                value: "ComplianceManager");

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
        }
    }
}
