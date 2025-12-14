using CouponManagement.Api.Domain;

namespace CouponManagement.Api.Services
{
    public interface ICouponRepository
    {
        void Add(Coupon coupon);
        List<Coupon> GetAll();
    }
}
