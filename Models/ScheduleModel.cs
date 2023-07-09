using System.ComponentModel.DataAnnotations;

namespace CalculoIndiceAcademico.Models
{
    public class ScheduleModel
    {
        [Key]
        public int ScheduleID { get; set; }
        public string day { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan? StartTime { get; set; }

        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "{0:hh\\:mm}", ApplyFormatInEditMode = true)]
        public TimeSpan? EndTime { get; set; }

    }
}
