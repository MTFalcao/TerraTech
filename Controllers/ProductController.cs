using Microsoft.AspNetCore.Mvc;

namespace WebSite.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Learn()
        {
            return View();
        }
    }
}
