using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoIndiceAcademico.Models
{
    public class RoomModel
    {
        [Key]
        public string RoomID { get; set; }

        public string? Description { get; set; }
        
    }
}
