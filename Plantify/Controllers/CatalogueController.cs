using Plantify.Infrastructure;
using Plantify.Models.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Plantify.Data;

namespace Plantify.Controllers
{
    public class CatalogueController : Controller
    {
        private PlantifyContext dataContext;
        public int PageSize = 9;


        public CatalogueController(PlantifyContext dbContext) { dataContext = dbContext; }

        // GET: Catalogue
        public ActionResult Index(string category, int page = 1)
        {
            ProductsListViewModel model = new ProductsListViewModel();
            model = new ProductsListViewModel
            {
                Products = dataContext.Products
                .OrderBy(p => p.ProductID)
                .Where(p => category == null || p.Category == category)
                .Skip((page - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null ?
                    dataContext.Products.Count() :
                    dataContext.Products.Where(e =>
                    e.Category == category).Count()
                },
                CurrentCategory = category
            };
            return View(model);
        }
    }
}
