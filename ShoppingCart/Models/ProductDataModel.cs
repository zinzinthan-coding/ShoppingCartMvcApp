using System.ComponentModel.DataAnnotations.Schema;

namespace ShoppingCart.Models
{
    [Table("Tbl_Product")]
    public class ProductDataModel
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public string? Image { get; set; }
        public string Description { get; set; }
        
    }
}
