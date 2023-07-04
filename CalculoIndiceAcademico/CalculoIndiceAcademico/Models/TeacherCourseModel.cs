using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoIndiceAcademico.Models
{
    public class TeacherCourseModel
    {
        public string CourseID { get; set; }
        [ForeignKey("CourseID")]
        public CourseModel CourseModel { get; set; }
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }
    }
}
