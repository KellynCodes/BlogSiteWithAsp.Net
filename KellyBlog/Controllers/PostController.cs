using KellyBlog.BLL.Interfaces;
using KellyBlog.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KellyBlog.Controllers
{
    public class PostController : Controller
    {
        private readonly ILogger<PostController> _logger;
        private readonly IPostServices _postServices;

        public PostController(ILogger<PostController> logger, IPostServices postServices)
        {
            _logger = logger;
            _postServices = postServices;
        }

        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Posts()
        {
            return View();
        }

        public async Task<IActionResult> SaveComment(PostVm postVm) 
        {
            if (ModelState.IsValid)
            {

                var (isSuccessful, msg) = await _postServices.CreatePostAsync(postVm);

                if (isSuccessful)
                {
                    TempData["SuccessMsg"] = msg;
                    return RedirectToAction("Post");
                }

                ViewBag.ErrMsg = msg;

                return View("New");

            }

            return View("Post");
        }
    }
}
