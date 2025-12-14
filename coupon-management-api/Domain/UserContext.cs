namespace CouponManagement.Api.Domain
{
    public class UserContext
    {
        public string UserId { get; set; } = string.Empty;
        public string UserTier { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public decimal LifetimeSpend { get; set; }
        public int OrdersPlaced { get; set; }
        public bool IsFirstOrder => OrdersPlaced == 0;
    }
}
