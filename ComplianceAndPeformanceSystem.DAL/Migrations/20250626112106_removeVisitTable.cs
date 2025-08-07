using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class removeVisitTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitDocuments");

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6804), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6818) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6828), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6829) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6831), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6831) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6833), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6833) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6835), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6835) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6839), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6839) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6841), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6841) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6843), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6843) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6856), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6857) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6860), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6862), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6862) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6863), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6864) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6865), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6865) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6867), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6868), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6869) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6870), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6870) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6871), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6872) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6874), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6875) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6876), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6877) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6878), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6879) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6880), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6882), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6882) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6883), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6884) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6885), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6886) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6887), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6889), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6890) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6891), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6892) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6893), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6893) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6895), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6895) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6896), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6897) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6898), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6900), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6901) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6902), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6907), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6909), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6909) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6910), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6911) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6912), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6914), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6915) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6916), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6916) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6917), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6918) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6919), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6920) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6931), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6931) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6933), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6933) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6934), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6935) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6936), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6937) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6938), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6939) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6940), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6940) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6941), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6943), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6945), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6946) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6947), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6947) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6949), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6949) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6950), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6951) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6952), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6953) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6954), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6954) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6956), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6956) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6958), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6960), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6961) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6962), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6963) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6964), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6964) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6966), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6966) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6967), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6968) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6969), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6970) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6971), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6971) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6972), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6973) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6976), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6977) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6978), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6978) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6980), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6981) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6982), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6983) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6984), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6984) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6986), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6987), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6988) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6989), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6990) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6991), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(6991) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7003), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7006), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7007), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7009), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7011), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7013), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7014), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7016), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7017) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7018), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7019) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7020), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7021), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7023), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7025), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7026) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7027), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7028), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7030), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7030) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7032), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7033), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7035), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7036), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7037) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7038), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7040), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7041), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7043), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7045), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7046), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7049), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7049) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7051), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7052), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7053) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7054), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7056), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7057), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7059), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7061), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7064), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7064) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7065), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7067), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7069), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7080), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7082), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7084), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7085), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7087), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7089), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7091), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7092), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7094), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7096), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7098), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7099), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7101), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7103), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7103) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7104), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7106), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7108), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7113), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7115), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7116), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7118), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7120), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7573), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7581), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7584), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7583) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7587), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7586) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7590), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7595), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7595) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7599), new DateTime(2025, 6, 26, 14, 21, 5, 131, DateTimeKind.Local).AddTicks(7598) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisitDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplianceDetailsID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    ModifiedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitDocuments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitDocuments_ComplianceDetails_ComplianceDetailsID",
                        column: x => x.ComplianceDetailsID,
                        principalTable: "ComplianceDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5701), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5711) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5714), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5714) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5716), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5718), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5718) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5719), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5721), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5722) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5723), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5723) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5724), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5725) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5726), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5728), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5729) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5731), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5731) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5732), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5733) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5734), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5736), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5736) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5737), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5738) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5739), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5739) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5741), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5741) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5749), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5749) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5751), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5751) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5752), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5754), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5755) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5756), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5756) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5758), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5759), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5760) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5761), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5763), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5763) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5764), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5766), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5767) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5769), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5770) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5771), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5772) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5773), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5773) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5774), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5775) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5776), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5777) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5778), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5779) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5780), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5780) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5782), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5782) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5783), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5784) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5785), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5785) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5787), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5787) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5788), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5790), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5792), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5793), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5795), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5797), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5797) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5798), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5799) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5801), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5801) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5802), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5804), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5805) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5806), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5807), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5809), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5816), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5818), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5818) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5819), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5820) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5821), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5823), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5824), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5826), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5826) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5827), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5829), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5831), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5833), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5833) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5834), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5835) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5837), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5837) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5839), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5839) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5840), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5842), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5843), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5844) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5845), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5846) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5847), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5848), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5850), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5852), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5854), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5856), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5857), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5860), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5860) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5861), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5863), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5865), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5865) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5866), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5868), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5870), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5872), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5880), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5880) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5882), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5883), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5885), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5887), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5888), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5890), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5892), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5893), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5895), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5896), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5898), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5900), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5902), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5903), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5906), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5907), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5908) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5909), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5910), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5911) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5912), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5914), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5915), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5917), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5917) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5919), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5920), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5922), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5922) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5923), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5925), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5927) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5928), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5930), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5931), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5932) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5933), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5934), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5936), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5938), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5939), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5940) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5941), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5942) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5943), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5943) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5950), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5951), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5952) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5953), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5955), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5956), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5957) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5958), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5961), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5962), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 132L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5964), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 133L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5966), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 134L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5967), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5968) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6249), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6248) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6255), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6254) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6257), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6257) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6259), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6259) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6262), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6261) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6265), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6264) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6267), new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(6267) });

            migrationBuilder.CreateIndex(
                name: "IX_VisitDocuments_ComplianceDetailsID",
                table: "VisitDocuments",
                column: "ComplianceDetailsID");
        }
    }
}
