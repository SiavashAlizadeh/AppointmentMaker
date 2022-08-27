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


        [DisplayName("patient's email address")]
        [DataType(DataType.EmailAddress)]
        
        public String emailAddress { get; set; }


        [DisplayName("patient's phone number")]
        [DataType(DataType.PhoneNumber)]
        public int patientNumber { get; set; }

        [Display(Name = "Zip Code")]
        [StringLength(10, MinimumLength = 5)]
        [RegularExpression("(^\\d{5}(-\\d{4})?$)|(^[ABCEGHJKLMNPRSTVXY]{1}\\d{1}[A-Z]{1} *\\d{1}[A-Z]{1}\\d{1}$)", ErrorMessage = "Zip code is invalid.")] // US or Canada
        [Required(ErrorMessage = "Zip Code is Required.")]
        public String zipCode { get; set; }

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
        [Range(5,10 , ErrorMessage ="unfortunatly your pain level is not high enough")]
        public int painLevel { get; set; }

        

        
    }
}
