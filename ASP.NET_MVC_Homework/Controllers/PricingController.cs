using ASP.NET_MVC_Homework.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC_Homework.Controllers
{
    public class PricingController : Controller
    {
        private readonly AppDbContext _context;
        public PricingController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
