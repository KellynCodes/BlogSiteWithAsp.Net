using KellyBlog.BLL.Implementations;
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

        public async Task<IActionResult> NewPost()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SavePost(PostVm postVm)
        {

            var (IsSuccessful, msg) = await _postServices.CreatePostAsync(postVm);

            if (IsSuccessful)
            {
                TempData["SuccessMsg"] = msg;
                return RedirectToAction("Index");
            }

            ViewBag.ErrMsg = msg;

            return RedirectToAction("Home");

            /* ViewBag.ErrMsg = "Chai ije uwa";
             return RedirectToAction("Post");*/
        }
    }
}
