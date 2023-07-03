using CalculoIndiceAcademico.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace CalculoIndiceAcademico.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
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

            modelBuilder.Entity<CourseSectionRoomModel>()
                        .HasKey(csr => new { csr.CourseID, csr.SectionID, csr.RoomID, csr.TrimesterID, csr.year, csr.day });

            modelBuilder.Entity<CourseReportModel>()
                        .HasKey(CoRepo => new { CoRepo.CourseID, CoRepo.UserID, CoRepo.TrimesterID, CoRepo.year });

        }

        public DbSet<BuildingModel> Buildings{ get; set; }
        public DbSet<CareerModel> Careers { get; set; }
        public DbSet<CoRequisiteModel> coRequisites { get; set; }
        public DbSet<CourseModel> Courses { get; set; }
        public DbSet<PreRequisiteModel> PreRequisites { get; set; }
        public DbSet<RoomModel> Rooms { get; set; }
        public DbSet<CourseReportModel> CourseReport { get; set; }
        public DbSet<CourseSectionRoomModel> CourseDetails { get; set; }
        public DbSet<InqueriesModel> Inqueries { get; set; }
        public DbSet<SectionModel> Sections { get; set; }
        public DbSet<TeacherCourseModel> TeachersCourses { get; set; }
        public DbSet<TrimesterModel> Trimesters { get; set; }
        public DbSet<UserCareerModel> UsersCareer { get; set; }
        public DbSet<UserInqueriesModel> userInqueries { get; set; }
    }
}