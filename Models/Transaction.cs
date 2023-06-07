using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeneralStoreAPI.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [ForeignKey("ProductId")]
        public int ProductId { get; set; }

        [Required]
        [ForeignKey("CustomerId")]
        public int CustomerId { get; set; }

        [Required]
        public int Quantity 
        { 
            get
            {
                if(Quantity >= 0)
                {
                    return Quantity;
                }else
                {
                    return 0;
                }
            } 
            set{}
            }
        
        [Required]
        public DateTime DateOfTransaction { get; set; }
    }
}