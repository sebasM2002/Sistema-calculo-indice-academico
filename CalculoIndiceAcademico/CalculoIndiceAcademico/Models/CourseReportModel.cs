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
        public int TrimesterID { get; set; }
        [ForeignKey("TrimesterID")]
        public TrimesterModel TrimesterModel { get; set; }

        public string year { get; set; }
        public float? Grade { get; set; }
        public char? Letter { get; set; }



    }
}
