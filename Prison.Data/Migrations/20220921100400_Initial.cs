using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Prison.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BehaviorLevels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LevelName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BehaviorLevels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CellTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CellTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Prisons",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxCapacity = table.Column<int>(type: "int", nullable: false),
                    CurrentCapacity = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prisons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SentenceGrades",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SentenceGrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VisitorsLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonthlyVisisted = table.Column<bool>(type: "bit", nullable: false),
                    DateOfVisit = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VisitorsLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cells",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    CellTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrisonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cells", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cells_CellTypes_CellTypeId",
                        column: x => x.CellTypeId,
                        principalTable: "CellTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cells_Prisons_PrisonId",
                        column: x => x.PrisonId,
                        principalTable: "Prisons",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Inmates",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BehaviorLevelId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CellId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SentenceGradeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PrisonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Modified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DoB = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SocialSecurityNr = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inmates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inmates_BehaviorLevels_BehaviorLevelId",
                        column: x => x.BehaviorLevelId,
                        principalTable: "BehaviorLevels",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inmates_Cells_CellId",
                        column: x => x.CellId,
                        principalTable: "Cells",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inmates_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Inmates_Prisons_PrisonId",
                        column: x => x.PrisonId,
                        principalTable: "Prisons",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Inmates_SentenceGrades_SentenceGradeId",
                        column: x => x.SentenceGradeId,
                        principalTable: "SentenceGrades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InmateVisitorsLog",
                columns: table => new
                {
                    InmatesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VisitorsLogsId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InmateVisitorsLog", x => new { x.InmatesId, x.VisitorsLogsId });
                    table.ForeignKey(
                        name: "FK_InmateVisitorsLog_Inmates_InmatesId",
                        column: x => x.InmatesId,
                        principalTable: "Inmates",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InmateVisitorsLog_VisitorsLogs_VisitorsLogsId",
                        column: x => x.VisitorsLogsId,
                        principalTable: "VisitorsLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cells_CellTypeId",
                table: "Cells",
                column: "CellTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cells_PrisonId",
                table: "Cells",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Inmates_BehaviorLevelId",
                table: "Inmates",
                column: "BehaviorLevelId");

            migrationBuilder.CreateIndex(
                name: "IX_Inmates_CellId",
                table: "Inmates",
                column: "CellId");

            migrationBuilder.CreateIndex(
                name: "IX_Inmates_GenderId",
                table: "Inmates",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Inmates_PrisonId",
                table: "Inmates",
                column: "PrisonId");

            migrationBuilder.CreateIndex(
                name: "IX_Inmates_SentenceGradeId",
                table: "Inmates",
                column: "SentenceGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_InmateVisitorsLog_VisitorsLogsId",
                table: "InmateVisitorsLog",
                column: "VisitorsLogsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InmateVisitorsLog");

            migrationBuilder.DropTable(
                name: "Inmates");

            migrationBuilder.DropTable(
                name: "VisitorsLogs");

            migrationBuilder.DropTable(
                name: "BehaviorLevels");

            migrationBuilder.DropTable(
                name: "Cells");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "SentenceGrades");

            migrationBuilder.DropTable(
                name: "CellTypes");

            migrationBuilder.DropTable(
                name: "Prisons");
        }
    }
}
