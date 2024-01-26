using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCartDataModel
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        public int Quantity { get; set; }

    }
}
