using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KellyBlog.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Index()
        {
            return View();
        }
    }
}
