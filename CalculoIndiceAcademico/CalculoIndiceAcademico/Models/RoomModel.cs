using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoIndiceAcademico.Models
{
    public class RoomModel
    {
        [Key]
        public string RoomID { get; set; }

        public int BuildingID { get; set; }
        [ForeignKey("BuildingID")]
        public BuildingModel BuildingModel { get; set; }
        
    }
}
