using Microsoft.AspNetCore.Mvc;

namespace KellyBlog.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
