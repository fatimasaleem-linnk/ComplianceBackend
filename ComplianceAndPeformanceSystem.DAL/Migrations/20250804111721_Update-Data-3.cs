using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateData3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ComplianceNotificationMassage",
                columns: new[] { "Id", "ActionUrl", "MessageBodyAR", "MessageBodyEn", "MessageTitleAR", "MessageTitleEn", "MessageType", "Role" },
                values: new object[,]
                {
                    { 39, "/", " يُرجى إكمال الإعداد في أقرب وقت ممكن", "Please complete the setup as soon as possible.", "انتهت فترة التحضير", "The preparation period has ended. ", "error", "ComplianceSpecialist" },
                    { 40, "/", " يُرجى اعطاء الموافقة او ارجاع الخطة", "Please approve or return the Plan as soon as possible.", "انتهت فترة الموافقة علي الخطة", "The Approval for Plan period has ended. ", "error", "PerformanceMonitoringManager" },
                    { 41, "/", " يُرجى اعطاء الموافقة او ارجاع الخطة", "Please approve or return the Plan as soon as possible.", "انتهت فترة الموافقة علي الخطة", "The Approval for Plan period has ended. ", "error", "ComplianceManager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 41);
        }
    }
}
