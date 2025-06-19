using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class test05 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CancellationReason",
                table: "ComplianceDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CancelledAt",
                table: "ComplianceDetails",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "RescheduleReason",
                table: "ComplianceDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ScheduledDate",
                table: "ComplianceDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "ComplianceDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "UpdatedReason",
                table: "ComplianceDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "DocumentExtensionRequest",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LicensedEntityId = table.Column<long>(type: "bigint", nullable: false),
                    ComplianceDetailsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestedDays = table.Column<int>(type: "int", nullable: true),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExtensionStatus = table.Column<int>(type: "int", nullable: true),
                    ReviewedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DecisionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FinalDays = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_DocumentExtensionRequest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentExtensionRequest_ComplianceDetails_ComplianceDetailsID",
                        column: x => x.ComplianceDetailsID,
                        principalTable: "ComplianceDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RescheduleRequests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensedEntityId = table.Column<long>(type: "bigint", nullable: false),
                    ComplianceDetailsID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProposedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ReviewedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReviewedByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ReviewReason = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RescheduleRequests", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RescheduleRequests_ComplianceDetails_ComplianceDetailsID",
                        column: x => x.ComplianceDetailsID,
                        principalTable: "ComplianceDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VisitStatusHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ComplianceDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionByUserId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RequestedNewDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitStatusHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VisitStatusHistories_ComplianceDetails_ComplianceDetailsId",
                        column: x => x.ComplianceDetailsId,
                        principalTable: "ComplianceDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExtensionStatusHistories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActionAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OldStatus = table.Column<int>(type: "int", nullable: true),
                    NewStatus = table.Column<int>(type: "int", nullable: false),
                    ActionReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NewFinalDays = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtensionStatusHistories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StatusHistories_RequestId",
                        column: x => x.RequestId,
                        principalTable: "DocumentExtensionRequest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4199), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4220), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4221) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4229), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4232), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4234) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4236), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4237) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4241), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4242) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4245), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4246) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4248), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4249) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4252), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4256), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4257) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4260), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4261) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4263), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4265) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4267), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4268) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4270), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4272) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4274), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4277), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4281), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4286), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4287) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4290), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4291) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4293), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4296), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4300), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4303), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4304) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4306), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4309), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4314), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4315) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4317), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4321), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4322) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4324), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4325) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4327), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4328) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4331), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4332) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4334), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4337), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4339) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4342), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4345), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4346) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4349), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4350) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4352), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4353) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4355), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4356) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4363), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4364) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4366), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4367) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4369), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4370) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4372), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4373) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4376), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4377) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4379), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4380) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4382), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4383) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4386), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4387) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4389), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4390) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4392), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4393) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4396), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4397) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4399), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4400) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4402), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4404) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4406), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4407) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4409), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4410) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4413), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4416), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4417) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4419), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4420) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4422), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4423) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4426), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4427) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4429), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4430) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4432), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4434) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4436), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4438) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4440), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4441) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4443), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4444) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4447), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4450), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4451) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4455), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4458), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4461), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4464), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4465) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4467), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4468) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4471), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4472) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4474), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4477), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4478) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4481), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4482) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4490), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4491) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4493), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4494) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4496), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4497) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4500), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4501) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4503), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4504) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4506), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4507) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4509), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4510) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4513), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4514) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4516), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4517) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4519), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4520) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4522), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4523) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4526), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4527) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4529), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4530) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4532), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4533) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4535), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4536) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4538), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4539) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4542), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4543) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4545), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4546) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4548), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4549) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4552), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4553) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4555), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4556) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4558), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4559) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4562), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4563) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4566), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4567) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4569), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4570) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4572), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4573) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4575), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4577) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4579), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4580) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4582), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4583) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4585), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4586) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4589), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4590) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4592), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4593) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4595), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4596) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4598), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4599) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4601), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4602) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4605), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4608), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4611), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4615), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4616) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4618), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4619) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4621), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4622) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4629), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4631) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4633), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4634) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4636), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4639), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4640) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4642), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4643) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4645), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4646) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4649), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4650) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4893), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4892) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4900), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4899) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4906), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4905) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4911), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4916), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4915) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4922), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4921) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4927), new DateTime(2025, 6, 19, 1, 42, 43, 806, DateTimeKind.Local).AddTicks(4926) });

            migrationBuilder.CreateIndex(
                name: "IX_DocumentExtensionRequest_ComplianceDetailsID",
                table: "DocumentExtensionRequest",
                column: "ComplianceDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_ExtensionStatusHistories_RequestId",
                table: "ExtensionStatusHistories",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_RescheduleRequests_ComplianceDetailsID",
                table: "RescheduleRequests",
                column: "ComplianceDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_VisitStatusHistories_ComplianceDetailsId",
                table: "VisitStatusHistories",
                column: "ComplianceDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ExtensionStatusHistories");

            migrationBuilder.DropTable(
                name: "RescheduleRequests");

            migrationBuilder.DropTable(
                name: "VisitStatusHistories");

            migrationBuilder.DropTable(
                name: "DocumentExtensionRequest");

            migrationBuilder.DropColumn(
                name: "CancellationReason",
                table: "ComplianceDetails");

            migrationBuilder.DropColumn(
                name: "CancelledAt",
                table: "ComplianceDetails");

            migrationBuilder.DropColumn(
                name: "RescheduleReason",
                table: "ComplianceDetails");

            migrationBuilder.DropColumn(
                name: "ScheduledDate",
                table: "ComplianceDetails");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "ComplianceDetails");

            migrationBuilder.DropColumn(
                name: "UpdatedReason",
                table: "ComplianceDetails");

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
        }
    }
}
