using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculoIndiceAcademico.Migrations
{
    public partial class AddFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ApplicationUser",
                table: "ApplicationUser");

            migrationBuilder.RenameTable(
                name: "ApplicationUser",
                newName: "Peoples");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Peoples",
                table: "Peoples",
                column: "UserID");

            migrationBuilder.CreateTable(
                name: "Tables",
                columns: table => new
                {
                    Data1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data2 = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseReport_Peoples_UserID",
                table: "CourseReport",
                column: "UserID",
                principalTable: "Peoples",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sections_Peoples_TeacherID",
                table: "Sections",
                column: "TeacherID",
                principalTable: "Peoples",
                principalColumn: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_TeachersCourses_Peoples_UserID",
                table: "TeachersCourses",
                column: "UserID",
                principalTable: "Peoples",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_userInqueries_Peoples_UserID",
                table: "userInqueries",
                column: "UserID",
                principalTable: "Peoples",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UsersCareer_Peoples_UserID",
                table: "UsersCareer",
                column: "UserID",
                principalTable: "Peoples",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseReport_Peoples_UserID",
                table: "CourseReport");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_Peoples_TeacherID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_TeachersCourses_Peoples_UserID",
                table: "TeachersCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_userInqueries_Peoples_UserID",
                table: "userInqueries");

            migrationBuilder.DropForeignKey(
                name: "FK_UsersCareer_Peoples_UserID",
                table: "UsersCareer");

            migrationBuilder.DropTable(
                name: "Tables");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Peoples",
                table: "Peoples");

            migrationBuilder.RenameTable(
                name: "Peoples",
                newName: "ApplicationUser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ApplicationUser",
                table: "ApplicationUser",
                column: "UserID");

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
    }
}
