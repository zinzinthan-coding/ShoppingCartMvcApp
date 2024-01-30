namespace ShoppingCart.Models
{
    public class CartListResponseModel
    {
        public int CartId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string Image { get; set; }
        public double TotalPrice { get; set; }
        public int Quantity { get; set; }
    }
}
