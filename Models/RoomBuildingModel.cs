using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoIndiceAcademico.Models
{
    public class RoomBuildingModel
    {
        public string RoomID { get; set; }
        [ForeignKey("RoomID")]
        public RoomModel RoomModel { get; set; }

        public int BuildingID { get; set; }
        [ForeignKey("BuildingID")]
        public BuildingModel BuildingModel { get; set; }
    }
}
