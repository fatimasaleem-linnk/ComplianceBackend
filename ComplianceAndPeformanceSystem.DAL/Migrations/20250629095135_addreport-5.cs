using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addreport5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LicenseGovernorate",
                table: "ComplianceReports");

            migrationBuilder.DropColumn(
                name: "Licensee",
                table: "ComplianceReports");

            migrationBuilder.RenameColumn(
                name: "LicenseId",
                table: "ComplianceReports",
                newName: "LicenseID");

            migrationBuilder.RenameColumn(
                name: "VisitType",
                table: "ComplianceReports",
                newName: "LicenseNumber");

            migrationBuilder.AlterColumn<long>(
                name: "LicenseID",
                table: "ComplianceReports",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "LocationID",
                table: "ComplianceReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "VisitTypeID",
                table: "ComplianceReports",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "AuditorID",
                table: "Auditors",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5796), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5809) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5814), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5816), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5817), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5819), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5821), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5822), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5822) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5823), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5824), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5826), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5828), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5829), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5829) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5830), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5840), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5841) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5842), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5842) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5843), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5843) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5844), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5845) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5846), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5847) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5848), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5848) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5849), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5850), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5851) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5852), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5853), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5854), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5854) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5855), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5857), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5857) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5858), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5859), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5860), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5861), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5862) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5863), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5863) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5864), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5864) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5865), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5867), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5867) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5868), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5869) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5870), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5870) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5871), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5871) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5872), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5872) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5873), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5874) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5875), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5875) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5876), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5876) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5877), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5878) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5879), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5881), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5881) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5882), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5883), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5884) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5885), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5886), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5886) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5892), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5894) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5894), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5895) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5896), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5896) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5897), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5898), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5900), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5900) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5901), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5901) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5902), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5902) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5903), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5904) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5905), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5905) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5906), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5907), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5907) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5908), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5912), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5912) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5913), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5913) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5914), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5915) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5916), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5917), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5918) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5919), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5919) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5920), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5921), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5921) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5922), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5923) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5923), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5924) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5925), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5925) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5926), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5926) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5927), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5928), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5929) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5930), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5931), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5932), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5934), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5934) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5936), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5936) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5937), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5937) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5938), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5939) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5946), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5947) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5947), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5948) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5949), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5950), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5951), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5952), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5953) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5954), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5954) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5955), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5955) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5956), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5956) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5957), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5958) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5959), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5959) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5960), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5960) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5961), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5961) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5962), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5963) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5963), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5964) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5966), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5966) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5967), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5967) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5968), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5969) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5970), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5970) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5971), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5971) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5972), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5972) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5973), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5974) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5974), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5975) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5976), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5976) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5977), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5977) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5978), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5978) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5979), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5981), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5981) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5982), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5982) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5983), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5984) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5984), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5986), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5986) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5987), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5989), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5989) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5990), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5991), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5991) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5992), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5993), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5995), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5995) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5996), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(5996) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6002), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6003) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6004), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6004) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6005), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6007), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6007) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6008), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6008) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6009), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6009) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6010), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6011) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 130L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6012), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6012) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 131L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6013), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(6014) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8448), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8444) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8452), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8452) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8455), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8455) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8458), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8460), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8460) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8464), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8466), new DateTime(2025, 6, 29, 12, 51, 34, 739, DateTimeKind.Local).AddTicks(8466) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LocationID",
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
        }
    }
}
