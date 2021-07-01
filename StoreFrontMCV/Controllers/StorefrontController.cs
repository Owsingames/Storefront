using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StoreFrontMCV.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StoreFrontMCV.Controllers
{
    public class StorefrontController : Controller
    {
        ProductsDbContext db = new ProductsDbContext();

        public IActionResult MainMenu()
        {
            return View();
        }
      
        public IActionResult Index()
        {
            List<Product> productList = db.Products.ToList();
            return View(productList);
        }

        //this will allow a user to buy a product
        //this is an Update function to the datebase
        public IActionResult Buy(int Id)
        {
            Product p = db.Products.Find(Id);
            return View(p);
        }



        //this will return the result of a purchase
        [HttpPost]
        public IActionResult Result()
        {
            return View();
        }

        public IActionResult ManageProduct()
        {
            return View("ManageProduct", "Inventory");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
