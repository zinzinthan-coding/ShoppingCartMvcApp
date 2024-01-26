using System.ComponentModel.DataAnnotations;

namespace ShoppingCart.Models
{
    public class CartDetailModel
    {
        public int Id { get; set; }
        [Required]
        public int CartId { get; set; }
        [Required]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Amount { get; set; }
        public ShoppingCartDataModel Cart { get; set; }
        public ProductDataModel Product { get; set; }
    }
}
