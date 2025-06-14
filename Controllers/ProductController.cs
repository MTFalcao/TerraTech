using Microsoft.AspNetCore.Mvc;
using static System.Collections.Specialized.BitVector32;
using static WebSite.Models.HintPageModel;
using WebSite.Models;

namespace WebSite.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Tips()
        {
            var model = new HintPageModel();
            return View(model);
        }
    }
}
