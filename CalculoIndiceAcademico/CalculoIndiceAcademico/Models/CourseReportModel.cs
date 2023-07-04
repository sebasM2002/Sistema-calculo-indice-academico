using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoIndiceAcademico.Models
{
    public class CourseReportModel
    {
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }
        public string CourseID { get; set; }
        [ForeignKey("CourseID")]
        public CourseModel CourseModel { get; set; }
        public int Section { get; set; }
        public int PeriodID{ get; set; }
        [ForeignKey("PeriodID")]
        public PeriodModel PeriodModel { get; set; }
        public float? Grade { get; set; }
        public char? Letter { get; set; }



    }
}
