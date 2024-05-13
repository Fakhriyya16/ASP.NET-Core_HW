using ASP.NET_MVC_Homework.Data;
using ASP.NET_MVC_Homework.Models;
using ASP.NET_MVC_Homework.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_MVC_Homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            SliderBackgroundImg sliderBackgroundImg =  _context.SliderBackgroundImgs.FirstOrDefault();
            List<Slider> sliders = await _context.Sliders.ToListAsync();
            HomeVM vm = new HomeVM()
            {
                SliderBackgroundImg = sliderBackgroundImg,
                Sliders = sliders
            };
            return View(vm);
        }
    }
}
