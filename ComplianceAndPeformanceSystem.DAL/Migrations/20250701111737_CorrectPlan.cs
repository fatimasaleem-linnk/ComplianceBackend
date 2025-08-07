using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class CorrectPlan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Action = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActorRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RelatedEntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ComplianceReportReviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplianceReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReviewerRole = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsApproved = table.Column<bool>(type: "bit", nullable: true),
                    ReasonForReturn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ReviewedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReviewedById = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComplianceReportReviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorrectiveActionPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplianceReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrectiveActionPlans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CorrectiveEvidences",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EvidenceStatus = table.Column<int>(type: "int", nullable: true),
                    CorrectiveActionPlanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CorrectiveEvidences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CorrectiveEvidences_CorrectiveActionPlans_CorrectiveActionPlanId",
                        column: x => x.CorrectiveActionPlanId,
                        principalTable: "CorrectiveActionPlans",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "LookupValue",
                columns: new[] { "Id", "CategoryId", "CreatedByEmail", "CreatedByID", "CreatedByUserName", "CreatedOn", "IsDeleted", "ModifiedByEmail", "ModifiedByID", "ModifiedByUserName", "ModifiedOn", "ValueAr", "ValueEn" },
                values: new object[] { 140L, 9L, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مرفقات الخطة التصحيحية", "CorrectPlanAttachment" });

            migrationBuilder.CreateIndex(
                name: "IX_CorrectiveEvidences_CorrectiveActionPlanId",
                table: "CorrectiveEvidences",
                column: "CorrectiveActionPlanId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityLogs");

            migrationBuilder.DropTable(
                name: "ComplianceReportReviews");

            migrationBuilder.DropTable(
                name: "CorrectiveEvidences");

            migrationBuilder.DropTable(
                name: "CorrectiveActionPlans");

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 140L);
        }
    }
}
