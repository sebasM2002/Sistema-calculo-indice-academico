using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoIndiceAcademico.Models
{
    public class TrimesterModel
    {
        [Key]
        public int semesterID { get; set; }

        [Required]
        public string semesterName { get; set; }
    }
}
