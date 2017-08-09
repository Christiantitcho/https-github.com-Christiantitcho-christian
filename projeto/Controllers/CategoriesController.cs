using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projeto.Models;

namespace projeto.Controllers
{
    public class CategoriesController : Controller
    {
        private static IList<Category> categoryList =
            new List<Category>() 
            {
                new Category() { CategoryId = 1, Name = "Keyboard" },
                new Category() { CategoryId = 1, Name = "Monitor" },
                new Category() { CategoryId = 1, Name = "Laptop" },
                new Category() { CategoryId = 1, Name = "Mouse" },
                new Category() { CategoryId = 1, Name = "Printer" }
            };
        // GET: Categories
        public ActionResult Index()
        {
            var listaOrdenada = categoryList
                .OrderBy(c => c.Name);

            return View(categoryList.OrderBy(c => c.Name));
        }

        private string Nome(Category c)
        {
            return c.Name;
        }
    }
}