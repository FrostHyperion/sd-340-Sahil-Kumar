using System.ComponentModel.DataAnnotations;

namespace DataAnnotations.Models
{
    public class Credit
    {
        
            [Key]
            public string CreditId { get; set; }

            public bool IsValid { get; set; }
            [StringLength(20)]
            public string HolderName { get; set; }

            public DateTime ExpiryDate { get; set; }

            public string ClientId { get; set; }
            public Client CLient { get; set; }
        
    }
}
