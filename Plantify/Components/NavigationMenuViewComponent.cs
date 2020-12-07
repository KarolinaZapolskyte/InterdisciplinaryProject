using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Plantify.Infrastructure;
using Plantify.Data;

namespace Plantify.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private PlantifyContext dataContext;
        public NavigationMenuViewComponent(PlantifyContext dbContext)
        {
            dataContext = dbContext;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(dataContext.Products
            .Select(x => x.Category)
            .Distinct()
            .OrderBy(x => x));
        }
    }
}

