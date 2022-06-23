using Microsoft.AspNetCore.Mvc;
using restaurant.Data;
using restaurant.Models;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurant.Controllers
{
    public class OnlineMenuController : Controller
    {
        private readonly AppDbContext context;
        public OnlineMenuController(AppDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index(int id)
        {

            dynamic mymodel = new ExpandoObject();



            mymodel.Categories = context.Categories.ToList();
            if (id == 0)
            {
                mymodel.Items = context.Items.Where(x => x.CategoryId == 1).ToList();
                if (id == 0) ViewBag.Name = "Starters";
                else ViewBag.Name = context.Categories.Find(id).Name;
            }
            else
            {
                mymodel.Items = context.Items.Where(x => x.CategoryId == id).ToList();
                ViewBag.Name = context.Categories.Find(id).Name;

            }

            //IEnumerable<Item> items = context.Items.Where(x=> x.CategoryId == c.Id);
            return View(mymodel);
        }

        
    }
}
