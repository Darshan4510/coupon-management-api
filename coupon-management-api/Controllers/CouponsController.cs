using CouponManagement.Api.Domain;
using CouponManagement.Api.Models;
using CouponManagement.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace CouponManagement.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CouponsController : ControllerBase
    {
        private readonly ICouponService _service;
        private readonly ICouponRepository _repository;

        public CouponsController(ICouponService service, ICouponRepository repository)
        {
            _service = service;
            _repository = repository;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateCouponRequest request)
        {
            var coupon = _service.CreateCoupon(request.Coupon);
            return Ok(coupon);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAllCoupons());
        }

        [HttpPost("best")]
        public IActionResult GetBestCoupon([FromBody] BestCouponRequest request)
        {
            var coupons = _repository.GetAll();

            Coupon? bestCoupon = null;
            decimal bestDiscount = 0;

            foreach (var coupon in coupons)
            {
                if (DateTime.UtcNow < coupon.StartDate || DateTime.UtcNow > coupon.EndDate)
                    continue;

                if (coupon.Eligibility.MinCartValue.HasValue &&
                    request.Cart.TotalValue < coupon.Eligibility.MinCartValue.Value)
                    continue;

                if (coupon.Eligibility.AllowedUserTiers != null &&
                    !coupon.Eligibility.AllowedUserTiers.Contains(request.User.UserTier))
                    continue;

                decimal discount = coupon.DiscountType == DiscountType.Flat
                    ? coupon.DiscountValue
                    : request.Cart.TotalValue * coupon.DiscountValue / 100;

                if (coupon.MaxDiscountAmount.HasValue)
                    discount = Math.Min(discount, coupon.MaxDiscountAmount.Value);

                if (discount > bestDiscount)
                {
                    bestDiscount = discount;
                    bestCoupon = coupon;
                }
            }

            return Ok(new BestCouponResponse
            {
                Coupon = bestCoupon,
                DiscountAmount = bestDiscount,
                FinalPrice = request.Cart.TotalValue - bestDiscount
            });
        }
    }
}
