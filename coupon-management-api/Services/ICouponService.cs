using CouponManagement.Api.Domain;

namespace CouponManagement.Api.Services
{
    public interface ICouponService
    {
        Coupon CreateCoupon(Coupon coupon);
        List<Coupon> GetAllCoupons();
    }
}
