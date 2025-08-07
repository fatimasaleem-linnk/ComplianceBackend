using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddPlanStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "LookupValue",
                columns: new[] { "Id", "CategoryId", "CreatedByEmail", "CreatedByID", "CreatedByUserName", "CreatedOn", "IsDeleted", "ModifiedByEmail", "ModifiedByID", "ModifiedByUserName", "ModifiedOn", "ValueAr", "ValueEn" },
                values: new object[,]
                {
                    { 141L, 7L, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "أخصائي الامتثال متاخر في اعداد الخطة", "Compliance Specialist Preparing Delayed" },
                    { 142L, 7L, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدير الامتثال متاخر", "Compliance Manager Overdue" },
                    { 143L, 7L, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مدير مراقبة الأداء متأخر", "Peformance Monitoring Manager Overdue" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 141L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 142L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 143L);
        }
    }
}
