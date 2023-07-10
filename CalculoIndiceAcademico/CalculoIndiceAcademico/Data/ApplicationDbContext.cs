using CalculoIndiceAcademico.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalculoIndiceAcademico.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CoRequisiteModel>()
                        .HasKey(c => new { c.CourseID, c.CoRequisiteID });
                        

            modelBuilder.Entity<PreRequisiteModel>()
                        .HasKey(p => new { p.CourseID, p.PreRequisiteID });

            modelBuilder.Entity<UserInqueriesModel>()
                        .HasKey(i => new { i.UserID, i.InqueryID });

            modelBuilder.Entity<UserCareerModel>()
                        .HasKey(career => new { career.ID_Career, career.UserID });

            modelBuilder.Entity<TeacherCourseModel>()
                        .HasKey(teaCo => new { teaCo.CourseID, teaCo.UserID });

            modelBuilder.Entity<CourseReportModel>()
                        .HasKey(CoRepo => new { CoRepo.CourseID, CoRepo.UserID, CoRepo.PeriodID});

            modelBuilder.Entity<SectionModel>()
                        .HasKey(sec => new {sec.CourseID, sec.Section, sec.PeriodID, sec.RoomID, sec.ScheduleID });

            modelBuilder.Entity<RoomBuildingModel>()
                        .HasKey(RoomB => new { RoomB.RoomID, RoomB.BuildingID});

        }
        public DbSet<APUser> Peoples { get; set; }
        public DbSet<Table_1> Tables { get; set; }
        public DbSet<BuildingModel> Buildings{ get; set; }
        public DbSet<CareerModel> Careers { get; set; }
        public DbSet<CoRequisiteModel> coRequisites { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<PreRequisiteModel> PreRequisites { get; set; }
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<RoomBuildingModel> RoomBuild { get; set; }
        public DbSet<ScheduleModel> Schedules { get; set; }
        public DbSet<CourseReportModel> CourseReport { get; set; }
        public DbSet<InqueriesModel> Inqueries { get; set; }
        public DbSet<SectionModel> Sections { get; set; }
        public DbSet<TeacherCourseModel> TeachersCourses { get; set; }
        public DbSet<PeriodModel> Trimesters { get; set; }
        public DbSet<UserCareerModel> UsersCareer { get; set; }
        public DbSet<UserInqueriesModel> userInqueries { get; set; }
        public DbSet<ApplicationUserModel> ApplicationUsers { get; set; }
        public DbSet<NamesModel> Names { get; set; }
        public DbSet<RolModel> Rol { get; set; }

    }
}