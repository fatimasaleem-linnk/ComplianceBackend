using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class visitandsurveytable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DesignedCapacity",
                table: "ComplianceDetails",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VisitDate",
                table: "ComplianceDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VisitReferenceNumber",
                table: "ComplianceDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "ComplianceVisitSpecialist",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplianceDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SpecialistUserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialistUserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SpecialistUserEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SurveyNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_ComplianceVisitSpecialist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ComplianceVisitSpecialist_ComplianceDetailsId",
                        column: x => x.ComplianceDetailsId,
                        principalTable: "ComplianceDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "VisitSurveyQuestion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionAr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuestionEn = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_VisitSurveyQuestion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitSurveyAnswer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplianceVisitSpecialistId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitSurveyQuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Answer = table.Column<bool>(type: "bit", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_VisitSurveyAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitSurveyAnswer_ComplianceVisitSpecialistId",
                        column: x => x.ComplianceVisitSpecialistId,
                        principalTable: "ComplianceVisitSpecialist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_VisitSurveyAnswer_VisitSurveyQuestionId",
                        column: x => x.VisitSurveyQuestionId,
                        principalTable: "VisitSurveyQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageType",
                value: "error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageType",
                value: "error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageType",
                value: "error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 7,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 8,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 9,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 10,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 11,
                column: "MessageType",
                value: "error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 12,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 14,
                column: "MessageType",
                value: "error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 15,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 16,
                column: "MessageType",
                value: "warning");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 17,
                column: "MessageType",
                value: "error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 18,
                column: "MessageType",
                value: "error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 19,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 20,
                column: "MessageType",
                value: "success");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 21,
                column: "MessageType",
                value: "success");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 22,
                column: "MessageType",
                value: "info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MessageBodyAR", "MessageBodyEn", "MessageTitleAR", "MessageTitleEn", "MessageType" },
                values: new object[] { " وسبب الارجاع {{ReturnReason}}", "Return reason is {{ReturnReason}}", " تمت اعادة الخطة من قبل مدير الادارة ", "The plan has been Returned by the Compliance Manager and .", "success" });

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MessageBodyAR", "MessageBodyEn", "MessageTitleAR", "MessageTitleEn", "MessageType" },
                values: new object[] { " وسبب الارجاع {{ReturnReason}}", "Return reason is {{ReturnReason}}.", "تمت اعادة الخطة من قبل مدير عام مراقبة الالتزام  ", "The plan has been Returned by the Performance Monitoring Manager", "success" });

            migrationBuilder.InsertData(
                table: "ComplianceNotificationMassage",
                columns: new[] { "Id", "ActionUrl", "MessageBodyAR", "MessageBodyEn", "MessageTitleAR", "MessageTitleEn", "MessageType", "Role" },
                values: new object[,]
                {
                    { 25, "/", "حان الوقت لجدولة زيارات لـ {QuarterName}. يرجى تحديد تواريخ الزيارات المعلقة في خطة الانتقال السنوية.", "It's time to schedule visits for {QuarterName}. Please indicate the dates of your pending visits in your annual transition plan.", "تذكير بجدولة الزيارات الربع سنوية", "Quarterly Visit Scheduling Reminder", "info", "ComplianceManager" },
                    { 26, "/", "الزيارة القادمة لـ {LicenseeName} في {VisitDate} وفقًا لخطة الامتثال السنوية. تحقق من بريدك الإلكتروني لتعيين فريق.", "{LicenseeName}'s next visit is on {VisitDate} according to the annual compliance plan. Check your email for team assignment.", "تذكير بتعيين فريق للزيارة", "Reminder to appoint a team for the visit", "info", "ComplianceManager" },
                    { 27, "/", " تم تحديد تضارب في المصالح بالنسبة لـ {LicenseeName} فيما يتعلق بزيارة {SpecialistName} في [تاريخ الزيارة]. اقترح النظام عضوًا بديلاً في الفريق.\r\nيرجى مراجعة المهمة وإكمالها.", "A conflict of interest was identified for {SpecialistName} regarding {LicenseeName}'s visit on [visit date]. The system has suggested an alternative team member.\r\nPlease review and complete the task.", "لا يتوفر اي عضو فريق للزيارة ", "No team member available for visit", "info", "ComplianceManager" },
                    { 28, "/", ":تاريخ الزيارة: {VisitDate} .\r\nاسم المرخص له: {LicenseeName}.\r\n أو توجد تعارضات{Reason}. ", "Date of visit: {VisitDate}.\r\nName of licensee: {LicenseeName}.\r\nReason for shortage: {Reason}.", "لا يتوفر اي عضو فريق للزيارة ", "No team member available for visit", "info", "ComplianceManager" },
                    { 29, "/", "والسبب {Reason}", "The reason is {Reason}.", "يوجد هناك تضارب في تعيينك ضمن الفريق وبالتالي سيتم استبعادك من الفريق.", "There is a conflict in your assignment to the team and therefore you will be removed from the team.", "error", "ComplianceManager" },
                    { 30, "/", "لقد تم تعيينك في الزيارة {VisitDate} يرجي العلم بان المدة المحددة لتحميل النماذج وارساله لنا في خلال يومين لتحميل النموذج في الرابط ادناه", "You have been appointed for visit {VisitDate} Please note that the time limit for downloading the forms and sending them to us is two days. To download the form, use the link below.", "لقد تم تعيينك في الزيارة {VisitDate} تأكد من ارسال نماذج الإفصاح خلال يومين ", "You have been assigned to {VisitDate}. Please ensure you submit your disclosure forms within 2 days.", "info", "ComplianceSpecialist" }
                });

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

            migrationBuilder.InsertData(
                table: "VisitSurveyQuestion",
                columns: new[] { "Id", "CreatedByEmail", "CreatedByID", "CreatedByUserName", "CreatedOn", "IsDeleted", "ModifiedByEmail", "ModifiedByID", "ModifiedByUserName", "ModifiedOn", "QuestionAr", "QuestionEn" },
                values: new object[,]
                {
                    { new Guid("f1f58c6f-0860-482a-be61-aa065b631920"), null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7236), null, null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7235), "هل لديك أي مصلحة تجارية أو شراكة أو نشاط مالي قد يؤثر على الزيارة؟", "Do you have any business interest, partnership, or financial activity that might affect the visit?" },
                    { new Guid("f1f58c6f-0860-482a-be61-aa065b631921"), null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7240), null, null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7240), "هل لديك أي أقارب من الدرجة الأولى إلى الرابعة يمتلكون عملاً تجاريًا أو لديهم مصلحة مالية مع الكيان الذي تتم زيارته؟", "Do you have any first- to fourth-degree relatives who own a business or have a financial interest in the entity being visited?" },
                    { new Guid("f1f58c6f-0860-482a-be61-aa065b631922"), null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7243), null, null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7243), "هل تشغل حاليًا أي منصب إداري أو عضوية في منظمة لها علاقات مباشرة أو غير مباشرة مع الجهة التي تتم زيارتها؟", "Do you currently hold any management position or membership in an organization that has direct or indirect ties to the visited entity?" },
                    { new Guid("f1f58c6f-0860-482a-be61-aa065b631923"), null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7246), null, null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7245), "هل لديك أي أقارب من الدرجة الأولى إلى الرابعة يشغلون مناصب إدارية  أو عضوية في جهة مرتبطة بالجهة التي تتم زيارتها؟", "Do you have any first- to fourth-degree relatives who hold administrative or membership positions in an organization related to the entity being visited?" },
                    { new Guid("f1f58c6f-0860-482a-be61-aa065b631924"), null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7249), null, null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7248), "هل لديك أي علاقات أو اتصالات سابقة مع موظفي الجهة التي قد تؤثر  على الزيارة؟", "Do you have any previous relationships or contacts with staff members that may affect the visit?" },
                    { new Guid("f1f58c6f-0860-482a-be61-aa065b631925"), null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7252), null, null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7252), "هل لديك أي أسباب قد تؤثر على قدرتك على إجراء الزيارة بموضوعية  واستقلالية؟", "Do you have any reasons that might affect your ability to conduct the visit objectively and independently?" },
                    { new Guid("f1f58c6f-0860-482a-be61-aa065b631926"), null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7255), null, null, null, null, new DateTime(2025, 6, 2, 8, 20, 2, 146, DateTimeKind.Local).AddTicks(7254), "هل لديك أي أقارب من الدرجة الأولى إلى الرابعة يمتلكون عملاً تجاريًا أو لديهم مصلحة مالية مع الكيان الذي تتم زيارته؟", "Do you have any first- to fourth-degree relatives who own a business or have a financial interest in the entity being visited?" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceVisitSpecialist_ComplianceDetailsId",
                table: "ComplianceVisitSpecialist",
                column: "ComplianceDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitSurveyAnswer_ComplianceVisitSpecialistId",
                table: "VisitSurveyAnswer",
                column: "ComplianceVisitSpecialistId");

            migrationBuilder.CreateIndex(
                name: "IX_VisitSurveyAnswer_VisitSurveyQuestionId",
                table: "VisitSurveyAnswer",
                column: "VisitSurveyQuestionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VisitSurveyAnswer");

            migrationBuilder.DropTable(
                name: "ComplianceVisitSpecialist");

            migrationBuilder.DropTable(
                name: "VisitSurveyQuestion");

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DropColumn(
                name: "DesignedCapacity",
                table: "ComplianceDetails");

            migrationBuilder.DropColumn(
                name: "VisitDate",
                table: "ComplianceDetails");

            migrationBuilder.DropColumn(
                name: "VisitReferenceNumber",
                table: "ComplianceDetails");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 1,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 2,
                column: "MessageType",
                value: "Error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 3,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 4,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 5,
                column: "MessageType",
                value: "Error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 6,
                column: "MessageType",
                value: "Error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 7,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 8,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 9,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 10,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 11,
                column: "MessageType",
                value: "Error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 12,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 13,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 14,
                column: "MessageType",
                value: "Error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 15,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 16,
                column: "MessageType",
                value: "Warning");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 17,
                column: "MessageType",
                value: "Error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 18,
                column: "MessageType",
                value: "Error");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 19,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 20,
                column: "MessageType",
                value: "Approval");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 21,
                column: "MessageType",
                value: "Success");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 22,
                column: "MessageType",
                value: "Info");

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MessageBodyAR", "MessageBodyEn", "MessageTitleAR", "MessageTitleEn", "MessageType" },
                values: new object[] { "", "", "تمت اعادة الخطة من قبل مدير الادارة", "The plan has been Returned by the Compliance Manager.", "Approval" });

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MessageBodyAR", "MessageBodyEn", "MessageTitleAR", "MessageTitleEn", "MessageType" },
                values: new object[] { "", "", "تمت اعادة الخطة من قبل مدير عام مراقبة الالتزام", "The plan has been Returned by the Performance Monitoring Manager.", "Success" });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6980), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6992), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6994), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6994) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6995), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6997), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6997) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(6999), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7000) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7001), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7001) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7002), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7002) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7003), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7004) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7005), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7007), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7007) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7008), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7009) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7010), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7012), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7012) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7013), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7013) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7014), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7015) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7022), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7024), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7024) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7025), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7025) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7026), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7027) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7028), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7028) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7029), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7029) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7030), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7031) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7032), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7032) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7033), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7034) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7035), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7035) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7036), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7037), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7038) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7038), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7039) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7040), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7040) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7041), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7042) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7043), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7043) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7045), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7045) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7047), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7047) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7048), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7048) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7049), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7050) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7051), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7051) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7052), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7052) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7053), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7055), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7055) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7056), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7056) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7057), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7059), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7059) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7060), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7061) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7061), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7062) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7063), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7063) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7064), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7066), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7066) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7067), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7067) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7068), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7070), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7071) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7072), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7072) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7073), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7074) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7081), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7081) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7082), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7082) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7084), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7084) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7085), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7085) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7086), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7088), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7088) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7089), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7089) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7090), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7092), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7092) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7093), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7093) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7094), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7095) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7096), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7096) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7098), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7099), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7100) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7101), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7101) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7102), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7103), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7104) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7105), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7105) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7106), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7107) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7107), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7108) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7109), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7109) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7110), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7111) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7112), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7112) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7113), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7113) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7114), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7115) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7116), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7116) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7117), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7117) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7118), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7119) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7120), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7120) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7121), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7122) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7122), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7123) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7124), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7124) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7125), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7127), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7128) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7129), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7129) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7130), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7130) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7137), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7137) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7138), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7138) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7139), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7141), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7141) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7142), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7142) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7143), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7145), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7145) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7146), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7147) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7147), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7148) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7149), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7149) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7150), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7151) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7152), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7153), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7155), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7155) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7156), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7156) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7158), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7158) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7159), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7159) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7161), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7161) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7162), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7162) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7163), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7165), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7166), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7166) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7167), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7170), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7170) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7171), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7172) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7173), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7174), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7174) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7175), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7177), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7177) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7178), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7178) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7179), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7180) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7181), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7181) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7182), new DateTime(2025, 4, 23, 11, 20, 0, 411, DateTimeKind.Local).AddTicks(7183) });
        }
    }
}
