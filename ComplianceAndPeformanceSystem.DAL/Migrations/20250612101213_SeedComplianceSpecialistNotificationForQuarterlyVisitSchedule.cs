using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedComplianceSpecialistNotificationForQuarterlyVisitSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ComplianceNotificationMassage",
                columns: new[] { "Id", "ActionUrl", "MessageBodyAR", "MessageBodyEn", "MessageTitleAR", "MessageTitleEn", "MessageType", "Role" },
                values: new object[] { 31, "/", "حان الوقت لجدولة زيارات لـ {QuarterName}. يرجى تحديد تواريخ الزيارات المعلقة في خطة الانتقال السنوية.", "It's time to schedule visits for {QuarterName}. Please indicate the dates of your pending visits in your annual transition plan.", "تذكير بجدولة الزيارات الربع سنوية", "Quarterly Visit Scheduling Reminder", "info", "ComplianceSpecialist" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6685), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6712) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6719), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6719) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6721), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6721) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6722), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6723) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6724), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6724) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6726), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6727) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6728), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6728) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6731), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6732) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6733), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6733) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6735), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6737), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6737) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6738), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6739) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6740), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6740) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6741), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6742) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6743), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6743) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6744), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6745) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6746), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6746) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6748), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6748) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6749), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6750) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6751), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6751) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6753), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6753) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6766), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6767) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6768), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6769) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6770), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6770) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6771), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6772) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6773), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6773) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6774), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6775) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6776), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6777) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6778), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6779) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6780), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6780) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6781), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6782) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6783), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6783) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6784), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6784) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6786), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6788), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6789), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6790) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6791), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6792), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6793) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6794), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6795), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6795) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6797), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6798), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6798) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6799), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6800) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6801), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6801) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6802), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6803) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6809), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6810) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6811), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6811) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6812), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6813) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6814), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6814) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6815), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6816) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6817), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6817) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6818), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6819) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6820), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6821) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6822), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6822) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6823), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6824) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6825), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6825) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6826), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6827) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6828), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6828) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6830), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6830) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6845), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6845) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6846), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6847) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6848), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6849), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6850) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6851), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6852) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6853), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6855), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6857), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6858), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6859) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6860), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6861), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6863), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6864), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6866), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6866) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6867), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6868), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6870), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6871), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6874), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6876), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6877), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6878) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6879), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6885), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6886), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6887) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6888), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6889), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6891), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6891) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6892), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6894), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6896), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6896) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6897), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6898) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6899), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6900), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6900) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6901), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6903), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6903) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6904), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6916), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6917), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6919), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6919) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6920), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6921) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6922), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6923) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6924), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6924) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6925), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6926) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6927), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6927) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6928), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6928) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6930), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6930) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6931), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6932) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6933), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6934), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6936), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6936) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6937), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6938) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6940), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6941), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6943), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6943) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6944), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6945) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6946), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6947), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6948) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6949), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6950), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6950) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6951), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6952) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6953), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6954), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6955) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6956), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7236), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7235) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7240), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7240) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7243), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7243) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7246), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7245) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7249), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7252), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7252) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7255), new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7254) });
        }
    }
}
