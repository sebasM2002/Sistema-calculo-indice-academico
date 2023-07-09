using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoIndiceAcademico.Models
{
    public class CoRequisiteModel
    {
        public string CourseID { get; set; }

        [ForeignKey("CourseID")]
        public CourseModel CourseModel { get; set; }
        public string CoRequisiteID { get; set; }
    }
}
