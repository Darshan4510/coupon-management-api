namespace CouponManagement.Api.Domain
{
    public class BestCouponResponse
    {
        public Coupon? Coupon { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
