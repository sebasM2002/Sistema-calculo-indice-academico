using System.ComponentModel.DataAnnotations;
namespace CalculoIndiceAcademico.Models
{
    public class CourseModel
    {
        [Key]
        public string CourseID { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public int Credits { get; set; }
    }
}
