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

        public async Task<IActionResult> Index(string userId, string postId)
        {
            var (post, isSuccessful, msg) = await _postServices.GetPostAsync(userId, postId);
            if (isSuccessful)
            {
                TempData["SuccessMsg"] = msg;
                return View(post);
            }

            ViewBag.ErrMsg = "Error fetching user.";
            return RedirectToAction("NewPost");
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
           if (ModelState.IsValid)
            {

          var (IsSuccessful, msg) = await _postServices.CreatePostAsync(postVm);

              if (IsSuccessful)
              {

                  TempData["SuccessMsg"] = msg;
                 Console.WriteLine(msg);
                  return RedirectToAction("NewPost");
              }

              ViewBag.ErrMsg = msg;
              return View("NewPost");

            }
              ViewBag.ErrMsg = "Sorry error occured. please check your entity.";
            return View("index");
        }
    }
}
