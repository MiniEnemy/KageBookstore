using Microsoft.AspNetCore.Mvc;
using My_bookStore.Data;
using My_bookStore.Models;

namespace My_bookStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;   
        }
        public IActionResult Index() // Displays all the categories 
        {
            List<Category> objCategoryList = _db.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create() //creates categories for genre and display the order
        {
             return View();
        }
    }
}
