using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restaurant.Data;
using restaurant.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace restaurant.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext context;
        public HomeController(AppDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {

            /*
             Category category = await context.Categories.Where(x => x.Slug == categorySlug).FirstOrDefaultAsync();
            if (category == null) return RedirectToAction("Index");
            int pageSize = 6;
            var product = context.Products.OrderByDescending(x => x.Id).Where(x=> x.CategoryId == category.Id).Skip((p - 1) * pageSize).Take(pageSize);

            ViewBag.PageNumber = p;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)context.Products.Where(x => x.CategoryId == category.Id).Count() / pageSize);
            ViewBag.CategoryName = category.Name;
            ViewBag.CategorySlug = categorySlug;
            return View(await product.ToListAsync());
             */
            IEnumerable<Category> category =  context.Categories;
            return View(category.ToList());
        }


        public IActionResult SignUp()
        {
            return View();
        }


        public IActionResult SignIn() => View();
        
    }
}
