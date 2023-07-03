using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CalculoIndiceAcademico.Models
{
    public class SectionModel
    {
        [Key]
        public int SectionID { get; set; }

        [Required]
        public string Section { get; set; }
    }
}
