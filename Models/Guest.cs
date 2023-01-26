using System.ComponentModel.DataAnnotations;

namespace CEHHotel.Models
{
    public class Guest
    {
        public int Id { get; set; }
        [StringLength(25, MinimumLength = 2)]
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [StringLength(25, MinimumLength = 2)]
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [StringLength(12, MinimumLength = 10)]
        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Display(Name = "Check-In")]
        [DataType(DataType.Date)]
        public DateTime CheckInDate { get; set; }

        [Display(Name = "Check-Out")]
        [DataType(DataType.Date)]
        public DateTime CheckOutDate { get; set; }

        [StringLength(16, MinimumLength =16)]
        [Display(Name = "Credit Card")]
        public string? CreditCardNum { get; set; }
        [Display(Name = "Photo ID")]
        public string? PhotoId { get; set; }
    }
}
