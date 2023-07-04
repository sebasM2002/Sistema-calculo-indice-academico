using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoIndiceAcademico.Models
{
    public class PeriodModel
    {
        [Key]
        public int semesterID { get; set; }

        [Required]
        public string period { get; set; }

        [Required]
        public string year { get; set; }
    }
}
