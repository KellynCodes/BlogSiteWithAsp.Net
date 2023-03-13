using KellyBlog.BLL.Implementations;
using KellyBlog.BLL.Interfaces;
using KellyBlog.BLL.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KellyBlog.Controllers
{
    public class PostController : Controller
    {

        private readonly ILogger<PostController> _logger;
        private readonly ICommentServices _commentServices;

        public PostController(ILogger<PostController> logger, ICommentServices commentServices)
        {
            _logger = logger;
            _commentServices = commentServices;
        }
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult Posts()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveComment(int postId, CommentsVm commentVm)
        {

            var (IsSuccessful, msg) = await _commentServices.CommentOnPostAsync(postId, commentVm);

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
