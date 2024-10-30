using Microsoft.AspNetCore.Mvc;

namespace My_bookStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
