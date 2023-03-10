using Microsoft.AspNetCore.Mvc;

namespace KellyBlog.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
