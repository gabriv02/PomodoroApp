using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PomodoroApp.Migrations
{
    public partial class AddPerson : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora",
                table: "People");

            migrationBuilder.AlterColumn<DateTime>(
                name: "Fecha",
                table: "People",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Fecha",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Hora",
                table: "People",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
