using CouponManagement.Api.Models;

namespace CouponManagement.Api.Domain
{
    public class Coupon
    {
        public string Code { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DiscountType DiscountType { get; set; }
        public decimal DiscountValue { get; set; }
        public decimal? MaxDiscountAmount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public Eligibility Eligibility { get; set; } = new();
    }
}
