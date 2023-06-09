using System.ComponentModel.DataAnnotations;

namespace GeneralStoreAPI.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}