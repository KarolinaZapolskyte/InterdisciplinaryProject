using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Plantify.Data;

namespace Plantify.Controllers
{
    public class ProductPageController : Controller
    {

        private PlantifyContext dataContext;

        public ProductPageController(PlantifyContext dbContext) { dataContext = dbContext; }



        public IActionResult Index(int id)
        {

            return View(dataContext.Products.Where(p => p.ProductID == id).FirstOrDefault());
        }
    }
}