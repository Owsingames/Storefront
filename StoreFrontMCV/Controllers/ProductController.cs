using Microsoft.AspNetCore.Mvc;
using StoreFrontMCV.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreFrontMCV.Controllers
{
    public class ProductController : Controller
    {
        ProductsDbContext db = new ProductsDbContext();

        public IActionResult ManageProduct()
        {
            return View();
        }
    }
}
