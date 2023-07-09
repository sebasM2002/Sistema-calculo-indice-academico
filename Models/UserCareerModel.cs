using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CalculoIndiceAcademico.Models
{
    public class UserCareerModel
    {
        public string ID_Career { get; set; }
        [ForeignKey("ID_Career")]
        public CareerModel CareerModel { get; set; }

        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public APUser User { get; set; }   

    }
}
