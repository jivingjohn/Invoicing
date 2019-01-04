using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Invoicing.Migrations
{
    public partial class RemovedDays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Days_DayID",
                table: "Activities");

            migrationBuilder.DropTable(
                name: "Days");

            migrationBuilder.DropIndex(
                name: "IX_Activities_DayID",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "DayID",
                table: "Activities");

            migrationBuilder.AddColumn<DateTime>(
                name: "Date",
                table: "Activities",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Date",
                table: "Activities");

            migrationBuilder.AddColumn<Guid>(
                name: "DayID",
                table: "Activities",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Days",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Day = table.Column<string>(nullable: false),
                    Weekday = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Days", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_DayID",
                table: "Activities",
                column: "DayID");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Days_DayID",
                table: "Activities",
                column: "DayID",
                principalTable: "Days",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
