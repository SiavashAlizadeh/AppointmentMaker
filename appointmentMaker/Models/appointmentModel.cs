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

        [DisplayName("City")]
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string City { get; set; }

        [DisplayName("Street")]
        [Required]
        [StringLength(20, MinimumLength = 4)]
        public string Street { get; set; }

        [DisplayName("appointment request Date")]
        [DataType(DataType.Date)]
        public DateTime appointmentDate { get; set; }

        [DisplayName("appointment request net worth")]
        [Range(90000, 9999999999999999.99 , ErrorMessage = "Your Currency should be above 90k")]
        [DataType(DataType.Currency)]
        public decimal patientNetWorth { get; set; }

        [DisplayName("appointment request doctor's name")]
        public String doctorsName { get; set; }

        [DisplayName("pain level is (1-10)")]
        [Range(1,10)]
        public int painLevel { get; set; }

        

        
    }
}
