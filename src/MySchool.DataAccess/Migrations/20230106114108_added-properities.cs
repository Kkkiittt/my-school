using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MySchool.DataAccess.Migrations
{
    public partial class addedproperities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Acted",
                table: "Students",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Acted",
                table: "Employees",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Acted",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "Acted",
                table: "Employees");
        }
    }
}
