namespace CouponManagement.Api.Domain
{
    public class Eligibility
    {
        public List<string>? AllowedUserTiers { get; set; }
        public decimal? MinLifetimeSpend { get; set; }
        public int? MinOrdersPlaced { get; set; }
        public bool FirstOrderOnly { get; set; }
        public List<string>? AllowedCountries { get; set; }
        public decimal? MinCartValue { get; set; }
        public int? MinItemsCount { get; set; }
        public List<string>? ApplicableCategories { get; set; }
        public List<string>? ExcludedCategories { get; set; }
    }
}
