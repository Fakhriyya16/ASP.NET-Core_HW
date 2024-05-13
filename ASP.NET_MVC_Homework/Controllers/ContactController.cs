using Microsoft.AspNetCore.Mvc;

namespace ASP.NET_MVC_Homework.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
