using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [StringLength(25,MinimumLength =3, ErrorMessage = "Name cannot exceed 25 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(25, MinimumLength = 3, ErrorMessage = "Name cannot exceed 25 characters")]
        public string LastName { get; set; }

        
        [RegularExpression(@"^[0-9]{10}$")]
        public string PhoneNumber { get; set; }

    }
}
