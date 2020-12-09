using Plantify.Infrastructure;
using Plantify.Models;
using Plantify.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Plantify.Data;

namespace Plantify.Controllers
{
    public class CartController : Controller
    {
        private Cart cart;
        private PlantifyContext dataContext;
        public CartController(PlantifyContext dbContext, Cart cartService)
        {
            dataContext = dbContext;
            cart = cartService;
        }
      

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int productID, string returnUrl)
        {
            Product product = dataContext.Products
            .FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productID, string returnUrl)
        {
            Product product = dataContext.Products
            .FirstOrDefault(p => p.ProductID == productID);
            if (product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
