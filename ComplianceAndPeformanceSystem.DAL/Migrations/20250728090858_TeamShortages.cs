﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ComplianceAndPeformanceSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class TeamShortages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TeamShortages",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ComplianceDetailsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LicensedEntityId = table.Column<long>(type: "bigint", nullable: true),
                    ShortageReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamShortages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamShortages_ComplianceDetails_ComplianceDetailsId",
                        column: x => x.ComplianceDetailsId,
                        principalTable: "ComplianceDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TeamShortages_ComplianceDetailsId",
                table: "TeamShortages",
                column: "ComplianceDetailsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamShortages");
        }
    }
}
