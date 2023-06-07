using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeneralStoreAPI.Models
{
    [Table("dev.Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public int QuantityInStock { get; set; }

        [Required]
        public double Price { get; set; }
    }
}