using System.ComponentModel.DataAnnotations;

namespace CalculoIndiceAcademico.Models
{
    public class RolModel
    {
        [Key]
        [Required]
        public string? UserID { get; set; }
        [Required]
        public string? Role { get; set; }
    }
}
