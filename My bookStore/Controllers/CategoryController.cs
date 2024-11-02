using Microsoft.AspNetCore.Mvc;
using My_bookStore.Data;
using My_bookStore.Models;
using System.Reflection.Metadata.Ecma335;

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

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.Displayorder.ToString()) // It  is checking is the Name and displayorder are same or not
            {
                ModelState.AddModelError("Name", "The Category Name and Display order can't be same");
            }

            if (obj.Name.ToLower() == "test" || obj.Name.ToLower() == "practice")
            {
                ModelState.AddModelError("", "You can't add Test or practice on Names");
            }


            if (ModelState.IsValid)
            {
                _db.Categories.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }


    }


}
