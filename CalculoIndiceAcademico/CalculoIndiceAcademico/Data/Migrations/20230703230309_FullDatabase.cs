using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CalculoIndiceAcademico.Data.Migrations
{
    public partial class FullDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rooms",
                columns: table => new
                {
                    RoomID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    BuildingID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rooms", x => x.RoomID);
                    table.ForeignKey(
                        name: "FK_Rooms_Buildings_BuildingID",
                        column: x => x.BuildingID,
                        principalTable: "Buildings",
                        principalColumn: "BuildingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InqueriesModel",
                columns: table => new
                {
                    InqueryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InqueryTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InqueryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InqueryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InqueriesModel", x => x.InqueryID);
                });

            migrationBuilder.CreateTable(
                name: "SectionModel",
                columns: table => new
                {
                    SectionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Section = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionModel", x => x.SectionID);
                });

            migrationBuilder.CreateTable(
                name: "TeacherCourseModel",
                columns: table => new
                {
                    CourseID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherCourseModel", x => new { x.CourseID, x.UserID });
                    table.ForeignKey(
                        name: "FK_TeacherCourseModel_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TeacherCourseModel_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TrimesterModel",
                columns: table => new
                {
                    semesterID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    semesterName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrimesterModel", x => x.semesterID);
                });

            migrationBuilder.CreateTable(
                name: "UserCareerModel",
                columns: table => new
                {
                    ID_Career = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCareerModel", x => new { x.ID_Career, x.UserID });
                    table.ForeignKey(
                        name: "FK_UserCareerModel_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserCareerModel_Careers_ID_Career",
                        column: x => x.ID_Career,
                        principalTable: "Careers",
                        principalColumn: "ID_Career",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserInqueriesModel",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InqueryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInqueriesModel", x => new { x.UserID, x.InqueryID });
                    table.ForeignKey(
                        name: "FK_UserInqueriesModel_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInqueriesModel_InqueriesModel_InqueryID",
                        column: x => x.InqueryID,
                        principalTable: "InqueriesModel",
                        principalColumn: "InqueryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseReportModel",
                columns: table => new
                {
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrimesterID = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Section = table.Column<int>(type: "int", nullable: false),
                    Grade = table.Column<float>(type: "real", nullable: true),
                    Letter = table.Column<string>(type: "nvarchar(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseReportModel", x => new { x.CourseID, x.UserID, x.TrimesterID, x.year });
                    table.ForeignKey(
                        name: "FK_CourseReportModel_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseReportModel_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseReportModel_TrimesterModel_TrimesterID",
                        column: x => x.TrimesterID,
                        principalTable: "TrimesterModel",
                        principalColumn: "semesterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseSectionRoomModel",
                columns: table => new
                {
                    CourseID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SectionID = table.Column<int>(type: "int", nullable: false),
                    RoomID = table.Column<string>(type: "nvarchar(10)", nullable: false),
                    TrimesterID = table.Column<int>(type: "int", nullable: false),
                    year = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    day = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    StartTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    EndTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    NumStudents = table.Column<int>(type: "int", nullable: true),
                    UserID = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseSectionRoomModel", x => new { x.CourseID, x.SectionID, x.RoomID, x.TrimesterID, x.year, x.day });
                    table.ForeignKey(
                        name: "FK_CourseSectionRoomModel_AspNetUsers_UserID",
                        column: x => x.UserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSectionRoomModel_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSectionRoomModel_Rooms_RoomID",
                        column: x => x.RoomID,
                        principalTable: "Rooms",
                        principalColumn: "RoomID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSectionRoomModel_SectionModel_SectionID",
                        column: x => x.SectionID,
                        principalTable: "SectionModel",
                        principalColumn: "SectionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseSectionRoomModel_TrimesterModel_TrimesterID",
                        column: x => x.TrimesterID,
                        principalTable: "TrimesterModel",
                        principalColumn: "semesterID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CourseReportModel_TrimesterID",
                table: "CourseReportModel",
                column: "TrimesterID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseReportModel_UserID",
                table: "CourseReportModel",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSectionRoomModel_RoomID",
                table: "CourseSectionRoomModel",
                column: "RoomID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSectionRoomModel_SectionID",
                table: "CourseSectionRoomModel",
                column: "SectionID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSectionRoomModel_TrimesterID",
                table: "CourseSectionRoomModel",
                column: "TrimesterID");

            migrationBuilder.CreateIndex(
                name: "IX_CourseSectionRoomModel_UserID",
                table: "CourseSectionRoomModel",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherCourseModel_UserID",
                table: "TeacherCourseModel",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserCareerModel_UserID",
                table: "UserCareerModel",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_UserInqueriesModel_InqueryID",
                table: "UserInqueriesModel",
                column: "InqueryID");

            migrationBuilder.CreateIndex(
                name: "IX_Rooms_BuildingID",
                table: "Rooms",
                column: "BuildingID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoomModel");

            migrationBuilder.DropTable(
                name: "CourseReportModel");

            migrationBuilder.DropTable(
                name: "CourseSectionRoomModel");

            migrationBuilder.DropTable(
                name: "TeacherCourseModel");

            migrationBuilder.DropTable(
                name: "UserCareerModel");

            migrationBuilder.DropTable(
                name: "UserInqueriesModel");

            migrationBuilder.DropTable(
                name: "SectionModel");

            migrationBuilder.DropTable(
                name: "TrimesterModel");

            migrationBuilder.DropTable(
                name: "InqueriesModel");
        }
    }
}
