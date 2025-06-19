using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class test01 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VisitDocuments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ComplianceDetailsID = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    CreatedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.InsertData(
                table: "ComplianceNotificationMassage",
                columns: new[] { "Id", "ActionUrl", "MessageBodyAR", "MessageBodyEn", "MessageTitleAR", "MessageTitleEn", "MessageType", "Role" },
                values: new object[,]
                {
                    { 31, "/", "و نوع الزيارة : تدقيق والمستندات المطلوبة تجدونها برفقة الإيميل الرسمي الخاص بكم {VisitDate} زيارة مجدولة يوم", "You have Scheduled visit on {VisitDate}, Visit Type: Audit and required documents send To Your Personal Email, ensure you submit your Documents within 5 days.", "{VisitDate}زيارة مجدولة يوم", "Scheduled visit on {VisitDate}", "info", "LicensedEntity" },
                    { 32, "/", "لقد تم تحميل مستنداتك الخاصة بزيارةالإمتثال بتاريخ (VisitDate) بنجاح شكراً لك.", "Your visit documents On (VisitDate) have been uploaded successfully. Thank you.", "تحميل المستندات الخاصة بزيارةالإمتثال", "Upload documents for compliance visit", "info", "LicensedEntity" },
                    { 33, "/", "لم يقدم الكيان المرخص له [LicensedEntityName]المستندات المطلوبة لزيارة الإمتثال المقررة في (VisitDate), يرجى المتابعة مع الكيان  فوراً ", "The licensed entity [LicensedEntityName] has not submitted the required documents for the compliance visit scheduled in (VisitDate), please follow up with the entity immediately", "تحميل المستندات الخاصة بزيارةالإمتثال", "Upload documents for compliance visit", "info", "ComplianceManager" },
                    { 34, "/", "لقد تم تقديم طلبك لتمديد (ExtensionDays) يوماً و هو الأن في إنتظار المراجعة. سيتم إخطارك بالقرار قريباً", "Your Extension request has been submitted (ExtensionDays) and is currently Under review. You will be notified of the decision soon.", "تمديد تحميل المستندات الخاصة بزيارةالإمتثال", "Extension for Upload documents for compliance visit", "info", "LicensedEntity" },
                    { 35, "/", " عزيزي ComplianceManager ,\"لقد تم تقديم طلب للتمديد إسم المرخص له (LicensedEntityName) و عددالأيام (ExtensionDays) يرجى المراجعة و قبوله أو رفضه مع سبب الرفض\"", " Dear ComplianceManager , \"A request for extension has been submitted for (LicensedEntityName) and Number of Days (ExtensionDays). Please review and accept or reject it with the reason for rejection\"", "لقد تم تقديم طلب للتمديد إسم المرخص له (LicensedEntityName) و عددالأيام (ExtensionDays) يوم, يرجى المراجعة و إختيار القرار المناسب", "An extension request has been submitted for (LicensedEntityName ) and the number of days is (ExtensionDays) days. Please review and choose the appropriate decision.", "info", "ComplianceManager" },
                    { 36, "/", " عزيزي ComplianceSpecialist ,\"لقد تم تقديم طلب للتمديد إسم المرخص له (LicensedEntityName) و عددالأيام (ExtensionDays) يرجى مراجعة الأمر  \"", " Dear ComplianceSpecialist , \"A request for extension has been submitted for (LicensedEntityName) and Number of Days (ExtensionDays). Please review \"", "لقد تم تقديم طلب للتمديد إسم المرخص له (LicensedEntityName) و عددالأيام (ExtensionDays) يوم, يرجى مراجعة الأمر", "An extension request has been submitted for (LicensedEntityName ) and the number of days is (ExtensionDays) days. Please review.", "info", "ComplianceSpecialist" },
                    { 37, "/", "لقد تمت الموافقة على طلبك لتمديد (ExtensionDays) يوماً,الموعد النهائي الجديد للتقديم هو تاريخ (ExtensionDate) ", "Your request for an extension of (ExtensionDays) has been approved. The new deadline to apply is (ExtensionDate).", "لقد تمت الموافقة على طلبك لتمديد (ExtensionDays) يوماً,الموعد النهائي الجديد للتقديم هو تاريخ (ExtensionDate) ", "Your request for an extension of (ExtensionDays) has been approved. The new deadline to apply is (ExtensionDate).", "info", "LicensedEntity" }
                });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9018), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9029) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9034), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9034) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9037), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9039), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9040) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9042), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9045), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9046) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9048), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9050), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9051) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9053), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9054) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9056), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9057) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9059), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9060) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9068), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9070) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9072), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9072) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9074), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9077), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9077) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9079), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9080) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9081), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9082) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9085), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9086) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9087), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9090), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9090) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9092), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9093) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9094), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9095) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9097), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9097) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9099), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9100) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9101), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9104), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9105) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9106), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9109), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9109) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9111), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9112) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9114), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9114) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9116), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9117) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9118), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9119) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9121), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9125), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9125) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9127), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9129), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9130) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9132), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9133) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9134), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9137), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9137) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9139), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9140) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9141), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9144), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9145) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9146), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9149), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9149) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9151), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9152) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9153), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9154) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9156), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9156) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9164), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9166) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9168), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9169) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9170), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9171) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9173), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9175), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9176) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9177), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9178) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9180), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9182), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9185), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9185) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9187), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9189), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9193), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9194) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9196), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9196) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9198), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9199) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9200), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9203), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9203) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9205), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9206) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9208), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9208) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9211), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9214), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9214) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9216), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9219), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9219) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9221), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9223), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9224) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9226), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9228), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9231), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9231) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9233), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9234) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9236), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9236) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9239), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9240) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9242), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9242) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9244), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9245) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9246), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9247) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9249), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9249) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9251), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9252) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9253), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9254) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9260), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9262) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9263), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9266), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9267) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9268), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9269) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9271), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9273), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9274) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9275), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9278), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9278) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9280), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9281) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9282), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9283) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9285), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9286) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9287), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9290), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9290) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9292), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9294), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9295) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9297), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9297) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9299), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9301), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9302) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9304), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9304) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9306), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9307) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9309), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9309) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9311), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9311) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9313), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9316), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9316) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9318), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9319) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9320), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9323), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9323) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9325), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9326) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9328), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9328) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9330), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9331) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9332), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9333) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9335), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9335) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9337), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9338) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9339), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9342), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9342) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9344), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9345) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9346), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9349), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9349) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9351), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9352) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9597), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9597) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9603), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9602) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9607), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9606) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9611), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9610) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9615), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9614) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9620), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9620) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9624), new DateTime(2025, 6, 16, 23, 6, 12, 641, DateTimeKind.Local).AddTicks(9623) });

            migrationBuilder.CreateIndex(
                name: "IX_VisitDocuments_ComplianceDetailsID",
                table: "VisitDocuments",
                column: "ComplianceDetailsID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitDocuments");

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 37);

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
