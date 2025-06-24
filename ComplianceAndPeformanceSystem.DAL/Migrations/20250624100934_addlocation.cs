using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addlocation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LocationVisit",
                table: "ComplianceDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1533), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1545), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1547), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1549), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1550), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1552), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1553), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1555), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1556), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1558), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1560), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1561), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1562), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1564), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1565), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1567), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1568), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1570), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1574), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1576), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1578), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1579), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1581), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1582), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1584), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1585), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1587), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1588), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1589), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1591), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1592), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1594), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1595), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1597), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1599), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1600), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1602), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1603), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1604), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1606), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1607), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1610), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1611), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1612), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1614), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1615), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1617), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1618), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1619), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1621), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1623), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1624), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1626), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1627), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1629), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1633), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1636), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1637), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1638), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1640), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1641), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1643), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1644), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1645), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1647), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1649), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1650), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1652), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1653), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1655), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1656), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1657), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1659), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1660), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1662), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1663), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1664), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1667), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1668), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1670), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1671), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1673), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1674), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1676), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1677), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1679), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1680), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1681), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1683), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1686), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1687), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1689), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1690), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1692), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1693), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1696), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1697), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1699), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1700), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1701), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1703), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1704), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1706), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1707), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1709), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1710), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1711), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1713), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1714), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1716), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1717), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1719), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1720), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1721), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1723), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1724), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1726), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1727), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1729), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1730), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1731), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1733), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1734), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1736), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1737), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1738), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1740), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1741), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1743), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2024), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2027), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2030), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2034), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2036), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2041), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2044), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2043) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationVisit",
                table: "ComplianceDetails");

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2031), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2044), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2044) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2046), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2046) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2047), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2053), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2053) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2055), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2056), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2057) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2058), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2059), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2061), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2061) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2063), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2063) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2064), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2064) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2065), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2067), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2067) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2068), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2069) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2070), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2071), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2072) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2073), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2073) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2074), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2075) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2076), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2076) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2077), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2078) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2079), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2079) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2080), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2083), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2084), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2084) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2085), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2086) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2087), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2087) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2088), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2090), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2091), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2091) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2092), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2093) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2094), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2094) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2095), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2097), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2098) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2099), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2100), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2100) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2102), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2103), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2103) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2107), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2108) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2109), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2110), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2111) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2112), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2112) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2113), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2113) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2114), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2115) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2116), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2117), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2118) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2119), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2119) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2120), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2120) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2122), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2123), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2123) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2124), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2125) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2126), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2127), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2127) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2128), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2130), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2131), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2132), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2133) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2134), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2134) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2135), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2135) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2138), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2138) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2139), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2139) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2140), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2142), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2142) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2143), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2143) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2144), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2145) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2146), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2147) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2148), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2148) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2149), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2150) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2151), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2151) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2152), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2152) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2153), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2154) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2155), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2156), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2157) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2160), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2160) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2161), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2162) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2163), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2164), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2166), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2166) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2167), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2167) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2168), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2169) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2170), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2170) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2171), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2173), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2174), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2174) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2175), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2176) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2177), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2178), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2178) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2180), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2181), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2182), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2183) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2184), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2184) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2185), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2187), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2187) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2188), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2188) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2189), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2190) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2191), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2192) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2193), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2194), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2195), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2196) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2197), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2197) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2198), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2199) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2200), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2201), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2201) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2202), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2204), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2205), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2206) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2206), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2207) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2208), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2208) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2209), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2211), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2211) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2212), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2212) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2213), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2217), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2219), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2220), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2220) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2222), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2223), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2223) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2224), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2225) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2226), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2227), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2229), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2229) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2230), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2230) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2231), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2232) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2233), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2233) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2234), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2234) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2235), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2236) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2237), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2238), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2239) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2240), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2240) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2393), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2392) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2396), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2396) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2399), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2402), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2401) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2404), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2404) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2409), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2408) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2411), new DateTime(2025, 6, 23, 10, 7, 6, 845, DateTimeKind.Local).AddTicks(2411) });
        }
    }
}
