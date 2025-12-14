using CouponManagement.Api.Domain;

namespace CouponManagement.Api.Services
{
    public class CouponService : ICouponService
    {
        private readonly ICouponRepository _repository;

        public CouponService(ICouponRepository repository)
        {
            _repository = repository;
        }

        public Coupon CreateCoupon(Coupon coupon)
        {
            _repository.Add(coupon);
            return coupon;
        }

        public List<Coupon> GetAllCoupons()
        {
            return _repository.GetAll();
        }
    }
}
