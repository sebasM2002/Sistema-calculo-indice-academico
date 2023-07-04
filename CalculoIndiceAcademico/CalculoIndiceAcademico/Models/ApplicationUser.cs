using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace CalculoIndiceAcademico.Models
{
    public class ApplicationUser
    {
        [Key]
        public string UserID { get; set; }

        public byte[]? Image { get; set; } 

        [Required]
        public int age { get; set; }

        public int? GPA { get; set; }

        public int? NumTrimesters { get; set; }

        public string EMail { get; set; }

        [Required]
        public char Gender { get; set; }

        public string? AcademicArea { get; set; }

        [Required]
        public string Identification { get; set; }

        [Required]
        public string AddressLine { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime BirthDate { get; set; }
    }
}
