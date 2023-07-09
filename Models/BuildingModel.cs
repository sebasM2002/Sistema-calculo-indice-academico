using System.ComponentModel.DataAnnotations;
namespace CalculoIndiceAcademico.Models
{
    public class BuildingModel
    {
        [Key]
        public int BuildingID { get; set; }
        [Required]
        public string BuildingName { get; set;}
    }
}
