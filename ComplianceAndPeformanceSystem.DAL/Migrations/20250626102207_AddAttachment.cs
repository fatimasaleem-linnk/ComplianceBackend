using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddAttachment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.CreateTable(
                name: "Attachments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttachmentGuid = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttachmentTypeId = table.Column<long>(type: "bigint", nullable: false),
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
                    table.PrimaryKey("PK_Attachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attachments_LookupValue_AttachmentTypeId",
                        column: x => x.AttachmentTypeId,
                        principalTable: "LookupValue",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CategoryLookup",
                columns: new[] { "Id", "NameAr", "NameEn" },
                values: new object[] { 9L, "نوع الملفات", "Attachment Type" });

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 29,
                column: "Role",
                value: "ComplianceSpecialist");

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

            
            migrationBuilder.InsertData(
                table: "LookupValue",
                columns: new[] { "Id", "CategoryId", "CreatedByEmail", "CreatedByID", "CreatedByUserName", "CreatedOn", "IsDeleted", "ModifiedByEmail", "ModifiedByID", "ModifiedByUserName", "ModifiedOn", "ValueAr", "ValueEn" },
                values: new object[,]
                {
                    { 132L, 9L, null, null, null, new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5964), null, null, null, null, new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5964), "مرفقات الزيارة", "VisitAttachment" },
                    { 133L, 9L, null, null, null, new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5966), null, null, null, null, new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5966), "المرفقات التابعة للتقارير", "ReportSendAttachment" },
                    { 134L, 9L, null, null, null, new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5967), null, null, null, null, new DateTime(2025, 6, 26, 13, 22, 6, 157, DateTimeKind.Local).AddTicks(5968), "المرفقات الرد للتقارير", "ReportReplyAttachment" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_AttachmentGuid",
                table: "Attachments",
                column: "AttachmentGuid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Attachments_AttachmentTypeId",
                table: "Attachments",
                column: "AttachmentTypeId");

            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attachments");

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 130L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 131L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 132L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 133L);

            migrationBuilder.DeleteData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 134L);

            migrationBuilder.DeleteData(
                table: "CategoryLookup",
                keyColumn: "Id",
                keyValue: 9L);

            migrationBuilder.UpdateData(
                table: "ComplianceNotificationMassage",
                keyColumn: "Id",
                keyValue: 29,
                column: "Role",
                value: "ComplianceManager");

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 1L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1533), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 2L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1545), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1546) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 3L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1547), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1548) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 4L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1549), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 5L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1550), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 6L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1552), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1552) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 7L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1553), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1554) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 8L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1555), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 9L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1556), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 10L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1558), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1559) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 11L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1560), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 12L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1561), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1561) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 13L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1562), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1563) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 14L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1564), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1564) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 15L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1565), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1566) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 16L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1567), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1567) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 17L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1568), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1569) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 18L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1570), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1571) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 19L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1574), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1575) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 20L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1576), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1577) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 21L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1578), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1578) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 22L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1579), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1580) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 23L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1581), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1581) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 24L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1582), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1583) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 25L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1584), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1584) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 26L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1585), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1586) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 27L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1587), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1587) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 28L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1588), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1588) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 29L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1589), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1590) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 30L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1591), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1591) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 31L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1592), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 32L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1594), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 33L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1595), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1596) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 34L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1597), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1598) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 35L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1599), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1599) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 36L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1600), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 37L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1602), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 38L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1603), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1604) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 39L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1604), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1605) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 40L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1606), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1606) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 41L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1607), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 42L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1610), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1610) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 43L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1611), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1611) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 44L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1612), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 45L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1614), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1614) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 46L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1615), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 47L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1617), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1617) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 48L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1618), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 49L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1619), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1620) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 50L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1621), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1622) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 51L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1623), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1623) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 52L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1624), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 53L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1626), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 54L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1627), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1628) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 55L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1629), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1629) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 56L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1633), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 57L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1636), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1636) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 58L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1637), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1637) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 59L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1638), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1639) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 60L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1640), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1640) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 61L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1641), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1642) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 62L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1643), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1643) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 63L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1644), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1644) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 64L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1645), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 65L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1647), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1647) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 66L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1649), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 67L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1650), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1651) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 68L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1652), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 69L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1653), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1654) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 70L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1655), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1655) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 71L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1656), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1656) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 72L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1657), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 73L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1659), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 74L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1660), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1661) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 75L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1662), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1662) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 76L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1663), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1664) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 77L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1664), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 78L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1667), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 79L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1668), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1669) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 80L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1670), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 81L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1671), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 82L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1673), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1673) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 83L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1674), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1675) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 84L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1676), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 85L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1677), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1678) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 86L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1679), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1679) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 87L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1680), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 88L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1681), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1682) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 89L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1683), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1683) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 90L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1686), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 91L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1687), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1688) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 92L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1689), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1689) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 93L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1690), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1691) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 94L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1692), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 95L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1693), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1693) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 96L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1696), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1696) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 97L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1697), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1698) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 98L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1699), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 99L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1700), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 100L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1701), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 101L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1703), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 102L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1704), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1705) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 103L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1706), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 104L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1707), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 105L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1709), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 106L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1710), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 107L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1711), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 108L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1713), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 109L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1714), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1715) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 110L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1716), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1716) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 111L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1717), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 112L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1719), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1719) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 113L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1720), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 114L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1721), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 115L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1723), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1723) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 116L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1724), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1725) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 117L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1726), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1726) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 118L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1727), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1727) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 119L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1729), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1729) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 120L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1730), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1730) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 121L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1731), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1732) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 122L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1733), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1733) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 123L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1734), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1735) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 124L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1736), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 125L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1737), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 126L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1738), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1739) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 127L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1740), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1740) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 128L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1741), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1742) });

            migrationBuilder.UpdateData(
                table: "LookupValue",
                keyColumn: "Id",
                keyValue: 129L,
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1743), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(1743) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631920"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2024), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2023) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631921"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2027), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2027) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631922"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2030), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2030) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631923"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2034), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2034) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631924"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2036), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2036) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631925"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2041), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2041) });

            migrationBuilder.UpdateData(
                table: "VisitSurveyQuestion",
                keyColumn: "Id",
                keyValue: new Guid("f1f58c6f-0860-482a-be61-aa065b631926"),
                columns: new[] { "CreatedOn", "ModifiedOn" },
                values: new object[] { new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2044), new DateTime(2025, 6, 24, 13, 9, 33, 622, DateTimeKind.Local).AddTicks(2043) });
        }
    }
}
