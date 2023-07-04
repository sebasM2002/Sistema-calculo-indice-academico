using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CalculoIndiceAcademico.Models
{
    public class SectionModel
    {
        public string CourseID { get; set; }
        [ForeignKey("CourseID")]
        public CourseModel courseModel { get; set; }
        public int Section { get; set; }
        public int PeriodID { get; set; }
        [ForeignKey("PeriodID")]
        public PeriodModel PeriodModel { get; set; }
        public string? TeacherID { get; set; }
        [ForeignKey("TeacherID")]
        public ApplicationUser User { get; set; }

        public int? NumStudents { get; set; }

        public string RoomID { get; set; }
        [ForeignKey("RoomID")]
        public RoomModel RoomModel { get;set; }

        public int ScheduleID { get; set; }
        [ForeignKey("ScheduleID")]
        public ScheduleModel ScheduleModel { get; set; }
    }
}
