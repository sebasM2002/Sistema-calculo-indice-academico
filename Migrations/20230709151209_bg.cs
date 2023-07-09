using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculoIndiceAcademico.Migrations
{
    public partial class bg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_roles",
                table: "roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeoplesModels",
                table: "PeoplesModels");

            migrationBuilder.RenameTable(
                name: "roles",
                newName: "Rols");

            migrationBuilder.RenameTable(
                name: "PeoplesModels",
                newName: "ApplicationUsers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Rols",
                table: "Rols",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers",
                column: "UserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Rols",
                table: "Rols");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUsers",
                table: "ApplicationUsers");

            migrationBuilder.RenameTable(
                name: "Rols",
                newName: "roles");

            migrationBuilder.RenameTable(
                name: "ApplicationUsers",
                newName: "PeoplesModels");

            migrationBuilder.AddPrimaryKey(
                name: "PK_roles",
                table: "roles",
                column: "UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeoplesModels",
                table: "PeoplesModels",
                column: "UserID");
        }
    }
}
