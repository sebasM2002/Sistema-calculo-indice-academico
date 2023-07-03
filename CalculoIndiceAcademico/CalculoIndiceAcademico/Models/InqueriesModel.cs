using System.ComponentModel.DataAnnotations;

namespace CalculoIndiceAcademico.Models
{
    public class InqueriesModel
    {
        [Key]
        public int InqueryID { get; set; }
        [Required]
        public string InqueryTitle{ get; set; }
        [Required]
        public string InqueryType { get; set;}
        public string? InqueryDescription { get; set;}
    }
}
