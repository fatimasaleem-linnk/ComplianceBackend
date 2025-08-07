using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class updatedata5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ComplianceNotificationMassage",
                columns: new[] { "Id", "ActionUrl", "MessageBodyAR", "MessageBodyEn", "MessageTitleAR", "MessageTitleEn", "MessageType", "Role" },
                values: new object[,]
                {
                    { 42, "/", "جاري المراجعة الأن من قبل المدير العام لمراقبة الاداء", "The plan is currently being reviewed by the Performance Monitoring Manager", "حالة مراجعة خطة الزيارات", "Visit Plan Review Status", "success", "PerformanceMonitoringManager" },
                    { 43, "/", "جاري المراجعة الأن من قبل المدير المباشر ", "The plan is currently being reviewed by the Compliance Manager.", "حالة مراجعة خطة الزيارات", "Visit Plan Review Status", "info", "ComplianceManager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 43);
        }
    }
}
