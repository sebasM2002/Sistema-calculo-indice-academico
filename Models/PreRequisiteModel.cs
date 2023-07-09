using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoIndiceAcademico.Models
{
    public class PreRequisiteModel
    {
        public string CourseID { get; set; }
        [ForeignKey("CourseID")]
        public CourseModel CourseModel { get; set; }
        public string PreRequisiteID { get; set; }
    }
}
