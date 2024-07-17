using Microsoft.AspNetCore.Mvc;

namespace Qing_Hong_Blog.Controllers
{
    public class ArticlesController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
