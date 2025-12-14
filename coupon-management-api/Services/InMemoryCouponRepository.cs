using CouponManagement.Api.Domain;

namespace CouponManagement.Api.Services
{
    public class InMemoryCouponRepository : ICouponRepository
    {
        private readonly List<Coupon> _coupons = new();

        public void Add(Coupon coupon)
        {
            _coupons.Add(coupon);
        }

        public List<Coupon> GetAll()
        {
            return _coupons;
        }
    }
}
