using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CalculoIndiceAcademico.Models
{
    public class CourseSectionRoomModel
    {
        public string CourseID { get; set; }
        [ForeignKey("CourseID")]
        public CourseModel courseModel { get; set; }

        public int SectionID { get; set; }
        [ForeignKey("SectionID")]
        public SectionModel sectionModel { get; set; }

        public string RoomID { get; set; }
        [ForeignKey("RoomID")]
        public RoomModel roomModel { get; set; }

        public int TrimesterID { get; set; }
        [ForeignKey("TrimesterID")]
        public TrimesterModel TrimesterModel { get; set; }

        public string year { get; set; }

        public string? day { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan? StartTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan? EndTime { get; set; }
        public int? NumStudents { get; set; }
        public string? UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

    }
}
