using Microsoft.AspNetCore.Mvc;

namespace CouponManagement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            return Array.Empty<WeatherForecast>();
        }
    }
}
