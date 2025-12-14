namespace CouponManagement.Api.Domain
{
    public class BestCouponRequest
    {
        public UserContext User { get; set; } = new();
        public Cart Cart { get; set; } = new();
    }
}
