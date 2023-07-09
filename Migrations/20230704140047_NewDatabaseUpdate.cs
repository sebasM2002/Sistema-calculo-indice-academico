using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculoIndiceAcademico.Migrations
{
    public partial class NewDatabaseUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseReport_AspNetUsers_UserID",
                table: "CourseReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_AspNetUsers_TeacherID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersCourses_AspNetUsers_UserID",
                table: "TeachersCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_userInqueries_AspNetUsers_UserID",
                table: "userInqueries");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersCareer_AspNetUsers_UserID",
                table: "UsersCareer");

            migrationBuilder.DropColumn(
                name: "AcademicArea",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "AddressLine",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GPA",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Identification",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NumTrimesters",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "age",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    age = table.Column<int>(type: "int", nullable: false),
                    GPA = table.Column<int>(type: "int", nullable: true),
                    NumTrimesters = table.Column<int>(type: "int", nullable: true),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    AcademicArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Identification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.UserID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseReport_ApplicationUser_UserID",
                table: "CourseReport",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_ApplicationUser_TeacherID",
                table: "Sections",
                column: "TeacherID",
                principalTable: "ApplicationUser",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersCourses_ApplicationUser_UserID",
                table: "TeachersCourses",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userInqueries_ApplicationUser_UserID",
                table: "userInqueries",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersCareer_ApplicationUser_UserID",
                table: "UsersCareer",
                column: "UserID",
                principalTable: "ApplicationUser",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseReport_ApplicationUser_UserID",
                table: "CourseReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_ApplicationUser_TeacherID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersCourses_ApplicationUser_UserID",
                table: "TeachersCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_userInqueries_ApplicationUser_UserID",
                table: "userInqueries");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersCareer_ApplicationUser_UserID",
                table: "UsersCareer");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.AddColumn<string>(
                name: "AcademicArea",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AddressLine",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "GPA",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "AspNetUsers",
                type: "nvarchar(1)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Identification",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "AspNetUsers",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumTrimesters",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "age",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseReport_AspNetUsers_UserID",
                table: "CourseReport",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_AspNetUsers_TeacherID",
                table: "Sections",
                column: "TeacherID",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersCourses_AspNetUsers_UserID",
                table: "TeachersCourses",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userInqueries_AspNetUsers_UserID",
                table: "userInqueries",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersCareer_AspNetUsers_UserID",
                table: "UsersCareer",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
