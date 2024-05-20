namespace NetCoreLearn.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CouponController : ControllerBase
    {
        PromotionsContext _context;

        public CouponController(PromotionsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Coupon> Get()
        {
            return _context.Coupons
                .AsNoTracking()
                .ToList();
        }
    }

}