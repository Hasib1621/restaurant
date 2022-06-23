using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restaurant.Controllers
{
    public class SetMealController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
