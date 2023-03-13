using KellyBlog.BLL.Interfaces;
using KellyBlog.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KellyBlog.Controllers
{
    public class CommentContoller : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

       
    }
}
