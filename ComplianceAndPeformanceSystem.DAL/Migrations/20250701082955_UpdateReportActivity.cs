using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReportActivity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReportActivities");

            migrationBuilder.AddColumn<Guid>(
                name: "ComplianceDetailId",
                table: "ComplianceReports",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "ReportRequestActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsReply = table.Column<bool>(type: "bit", nullable: false),
                    ReplyComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ComplianceDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_ReportRequestActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportRequestActivities_ComplianceDetails_ComplianceDetailsId",
                        column: x => x.ComplianceDetailsId,
                        principalTable: "ComplianceDetails",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ReportRequestActivities_ComplianceReports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "ComplianceReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ComplianceReports_ComplianceDetailId",
                table: "ComplianceReports",
                column: "ComplianceDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportRequestActivities_ComplianceDetailsId",
                table: "ReportRequestActivities",
                column: "ComplianceDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_ReportRequestActivities_ReportId",
                table: "ReportRequestActivities",
                column: "ReportId");

            migrationBuilder.AddForeignKey(
                name: "FK_ComplianceReports_ComplianceDetails_ComplianceDetailId",
                table: "ComplianceReports",
                column: "ComplianceDetailId",
                principalTable: "ComplianceDetails",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ComplianceReports_ComplianceDetails_ComplianceDetailId",
                table: "ComplianceReports");

            migrationBuilder.DropTable(
                name: "ReportRequestActivities");

            migrationBuilder.DropIndex(
                name: "IX_ComplianceReports_ComplianceDetailId",
                table: "ComplianceReports");

            migrationBuilder.DropColumn(
                name: "ComplianceDetailId",
                table: "ComplianceReports");

            migrationBuilder.CreateTable(
                name: "ReportActivities",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    IsReply = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedByEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedByUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReplyComment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestComment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReportActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ReportActivities_ComplianceReports_ReportId",
                        column: x => x.ReportId,
                        principalTable: "ComplianceReports",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReportActivities_ReportId",
                table: "ReportActivities",
                column: "ReportId");
        }
    }
}
