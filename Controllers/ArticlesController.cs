using Microsoft.AspNetCore.Mvc;

namespace Qing_Hong_Blog.Controllers
{
    public class ArticlesController : Controller
    {
        public IActionResult index()
        {
            return View();
        }

        public IActionResult att()
        {
            return View();
        }
    }
}
