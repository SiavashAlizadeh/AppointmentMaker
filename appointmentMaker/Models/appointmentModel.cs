using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace appointmentMaker.Models
{
    public class appointmentModel
    {
        [Required]
        [StringLength(20,MinimumLength =4)]

        [DisplayName("patient's full name")]
        public String patientName { get; set; }

        [DisplayName("appointment request Data")]

        [DataType(DataType.Date)]
        public DateTime appointmentDate { get; set; }

        [DisplayName("appointment request net worth")]
        [DataType(DataType.Currency)]
        public decimal patientNetWorth { get; set; }

        [DisplayName("appointment request doctor's name")]

        public String doctorsName { get; set; }

        [DisplayName("pain level is (1-10)")]
        [Range(1,10)]
        public int painLevel { get; set; }
    }
}
