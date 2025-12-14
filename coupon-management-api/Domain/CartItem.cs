using CouponManagement.Api.Domain;

namespace CouponManagement.Api.Domain
{
    public class CartItem
    {
        public string ProductId { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}


public class Cart
{
    public List<CartItem> Items { get; set; } = new();

    public decimal TotalValue => Items.Sum(i => i.UnitPrice * i.Quantity);
    public int TotalItems => Items.Sum(i => i.Quantity);
}