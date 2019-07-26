using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SummerInternRegistration.Migrations
{
    public partial class Version1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "TIMESTAMP",
                table: "Intern",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NOTES",
                table: "Intern",
                nullable: true,
                oldClrType: typeof(decimal));

            migrationBuilder.AlterColumn<double>(
                name: "GPA",
                table: "Intern",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TIMESTAMP",
                table: "Intern",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<decimal>(
                name: "NOTES",
                table: "Intern",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "GPA",
                table: "Intern",
                nullable: true,
                oldClrType: typeof(double));
        }
    }
}
