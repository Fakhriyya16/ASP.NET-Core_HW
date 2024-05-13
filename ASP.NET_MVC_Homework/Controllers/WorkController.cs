using ASP.NET_MVC_Homework.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC_Homework.Controllers
{
    public class WorkController : Controller
    {
        private readonly AppDbContext _context;
        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
