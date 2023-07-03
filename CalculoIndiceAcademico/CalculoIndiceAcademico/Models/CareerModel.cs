using System.ComponentModel.DataAnnotations;
namespace CalculoIndiceAcademico.Models
{
    public class CareerModel
    {
        [Key]
        public string ID_Career { get; set; }
        [Required]
        public string Career { get; set; }
    }
}
