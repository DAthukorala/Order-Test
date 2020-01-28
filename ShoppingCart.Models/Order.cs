namespace ShoppingCart.Models
{
    public class Order
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal Cost { get; set; }        
        public Customer Customer { get; set; }
    }
}
