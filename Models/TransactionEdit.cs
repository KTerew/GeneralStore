using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeneralStoreAPI.Models
{
    public class TransactionEdit
    {
        [Required]
        [ForeignKey("Product")]
        public int ProductId { get; set; }

        [Required]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        [Required]
        public int Quantity { get; set; }
    }
}