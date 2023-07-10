using System.ComponentModel.DataAnnotations;

namespace CalculoIndiceAcademico.Models
{
    public class NamesModel
    {
        [Key]
        [Required]
        public string UserID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string LastName { get; set; }
    }
}
