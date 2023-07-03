using System.ComponentModel.DataAnnotations.Schema;

namespace CalculoIndiceAcademico.Models
{
    public class UserInqueriesModel
    {
        public string UserID { get; set; }
        [ForeignKey("UserID")]
        public ApplicationUser User { get; set; }

        public int InqueryID { get; set; }
        [ForeignKey("InqueryID")]
        public InqueriesModel InqueriesModel { get; set; }
    }
}
