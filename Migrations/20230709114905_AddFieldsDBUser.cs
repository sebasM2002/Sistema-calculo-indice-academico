using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculoIndiceAcademico.Migrations
{
    public partial class AddFieldsDBUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "ApplicationUser");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "ApplicationUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ApplicationUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "ApplicationUser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastName",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ApplicationUser");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "ApplicationUser");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "ApplicationUser",
                type: "varbinary(max)",
                nullable: true);
        }
    }
}
