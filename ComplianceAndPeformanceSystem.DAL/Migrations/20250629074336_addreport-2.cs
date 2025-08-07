using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addreport2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "ReportSubCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "ReportEntries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "ReportCategories",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1573), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1585), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1585) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1587), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1588), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1589) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1590), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1591), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1592) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1593), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1594), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1595), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1597), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1599), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1600), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1600) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1601), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1603), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1603) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1604), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1605), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1607), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1607) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1609), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1609) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1617), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1618), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1619), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1621), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1622), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1623), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1625), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1626), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1627), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1628), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1629), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1631), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1631) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1632), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1632) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1633), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1633) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1634), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1636), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1637), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1638) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1640), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1641), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1642), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1643), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1645), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1645) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1646), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1647), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1648), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1650), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1650) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1651), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1652), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1653), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1653) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1654), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1656), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1657), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1658), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1659), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1660) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1661), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1663), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1664), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1671), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1671) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1672), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1673), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1675), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1676), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1677), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1677) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1678), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1679), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1681), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1682), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1684), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1684) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1685), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1686), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1687), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1689), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1690), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1692), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1694), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1694) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1695), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1695) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1696), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1697), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1699), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1700), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1701), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1701) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1702), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1703), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1704) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1705), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1706), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1707), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1707) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1708), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1710), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1711), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1711) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1712), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1713), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1714) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1716), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1720), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1721) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1721), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1723), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1724), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1724) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1725), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1726), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1728), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1729), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1730), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1731), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1733), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1734), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1735), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1736), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1737), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1738) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1739), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1740), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1742), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1743), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1744), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1745) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1746), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1747), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1747) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1748), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1749), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1750) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1751), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1752), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1752) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1753), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1753) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1754), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1755), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1756) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1757), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1757) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1758), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1759), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1759) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1760), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1761), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1762) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1763), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1763) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1764), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1764) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1765), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1765) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1766), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1767) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1767), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1768) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1774), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1775), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(1775) });

            migrationBuilder.InsertData(
                table: "ReportCategories",
                columns: new[] { "Id", "IsDeleted", "Name", "NameAr" },
                values: new object[,]
                {
                    { 1, false, "Legal & Regulation", "القانونية والتنظيمية" },
                    { 2, false, "Financial", "مالي" },
                    { 3, false, "Technical", "فني" },
                    { 4, false, "Consumer Service", "خدمة المستهلك" }
                });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(3996), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(3992) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4001), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4000) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4003), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4003) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4006), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4005) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4008), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4008) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4011), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4010) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4014), new DateTime(2025, 6, 29, 10, 43, 36, 261, DateTimeKind.Local).AddTicks(4013) });

            migrationBuilder.InsertData(
                table: "ReportSubCategories",
                columns: new[] { "Id", "CategoryID", "IsDeleted", "Name", "NameAr" },
                values: new object[,]
                {
                    { 11, 1, false, "Compliance", "الامتثال" },
                    { 12, 1, false, "Licensing requirements", "متطلبات الترخيص" },
                    { 13, 1, false, "Organization & capabilities", "الهيكل التنظيمي والقدرات" },
                    { 21, 2, false, "Accounting requirements", "متطلبات المحاسبة" },
                    { 22, 2, false, "Financial information", "المعلومات المالية" },
                    { 31, 3, false, "Organization & capabilities", "الهيكل التنظيمي والقدرات" },
                    { 32, 3, false, "Regulatory requirements", "المتطلبات التنظيمية" },
                    { 41, 4, false, "Consumer information", "معلومات المستهلك" },
                    { 42, 4, false, "Consumer satisfaction", "رضا المستهلك" }
                });

            migrationBuilder.InsertData(
                table: "ReportEntries",
                columns: new[] { "Id", "IsDeleted", "Name", "NameAr", "SupCategoryID" },
                values: new object[,]
                {
                    { 111, false, "Complied with licensed facility's design capacity data", "الامتثال لبيانات الطاقة التصميمية للمنشأة المرخصة", 11 },
                    { 112, false, "Implemented recommendations from previous audits within defined period", "تنفيذ التوصيات من عمليات التدقيق السابقة ضمن الفترة المحددة", 11 },
                    { 113, false, "Provided data/information requested by SWA in an approved format", "تقديم البيانات/المعلومات المطلوبة من الهيئة بالصيغة المعتمدة", 11 },
                    { 114, false, "Supported audit team and complied with requests", "دعم فريق التدقيق والامتثال للطلبات", 11 },
                    { 121, false, "Obtained a land title deed for licensed facility/asset", "الحصول على صك ملكية للأصل أو المنشأة المرخصة", 12 },
                    { 122, false, "Obtained a valid license or permit as per law", "الحصول على ترخيص أو تصريح ساري حسب النظام", 12 },
                    { 123, false, "Obtained required approvals for mergers/acquisitions", "الحصول على الموافقات اللازمة للاندماجات أو الاستحواذات", 12 },
                    { 131, false, "Established compliance department and defined job descriptions", "إنشاء إدارة امتثال وتحديد الوصف الوظيفي", 13 },
                    { 132, false, "Submitted and obtained approval for the compliance plan", "تقديم واعتماد خطة الامتثال", 13 },
                    { 211, false, "Established an updated fixed asset register (FAR)", "إعداد سجل الأصول الثابتة المحدّث", 21 },
                    { 212, false, "Implemented separate accounts for licensed activities", "تطبيق حسابات منفصلة للأنشطة المرخصة", 21 },
                    { 221, false, "Submitted annual audited financial statements", "تقديم القوائم المالية السنوية المدققة", 22 },
                    { 222, false, "Provided valid and accurate commercial agreements", "تقديم اتفاقيات تجارية صحيحة ودقيقة", 22 },
                    { 223, false, "Submitted and obtained approval for revenue management method", "تقديم واعتماد آلية إدارة الإيرادات", 22 },
                    { 311, false, "Mechanism for monitoring and controlling water quality", "آلية مراقبة وضبط جودة المياه", 31 },
                    { 312, false, "Established operational plans", "إعداد خطط تشغيلية", 31 },
                    { 313, false, "Established maintenance and incident reporting plans", "إعداد خطط الصيانة والتقارير عن الحوادث", 31 },
                    { 314, false, "Established risk and emergency management plans", "إعداد خطط إدارة المخاطر والطوارئ", 31 },
                    { 321, false, "Complied with KSA localization and operational performance standards", "الامتثال لمعايير التوطين والأداء التشغيلي في المملكة", 32 },
                    { 322, false, "Disposed wastewater treated as per standards", "تصريف مياه الصرف الصحي المعالجة حسب المعايير", 32 },
                    { 411, false, "Kept encrypted consumer data, restricting access to required employees", "حفظ بيانات المستهلك بشكل مشفر وتقييد الوصول", 41 },
                    { 412, false, "Made service information publicly available", "إتاحة معلومات الخدمة للعامة", 41 },
                    { 421, false, "Established a call center for consumer inquiries", "إنشاء مركز اتصال لاستفسارات المستهلك", 42 },
                    { 422, false, "Provided training for employees dealing with consumers", "تقديم تدريب للموظفين للتعامل مع المستهلكين", 42 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "ReportEntries",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "ReportSubCategories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ReportSubCategories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ReportSubCategories",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ReportSubCategories",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ReportSubCategories",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ReportSubCategories",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ReportSubCategories",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ReportSubCategories",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ReportSubCategories",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ReportCategories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "ReportSubCategories");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "ReportEntries");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "ReportCategories");

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
        }
    }
}
