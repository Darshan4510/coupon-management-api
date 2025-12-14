namespace CouponManagement.Api.Domain
{
    public class CreateCouponRequest
    {
        public Coupon Coupon { get; set; } = new();
    }
}
