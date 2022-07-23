using Microsoft.AspNetCore.Mvc;
using Coffee_Shop_Products.Models;

namespace Coffee_Shop_Products.Controllers
{
    public class ProductController : Controller
    {
        private CoffeeShopDBContext context = new CoffeeShopDBContext();
        public IActionResult Index()
        {
            List<Coffee> result = context.Coffees.ToList();
            return View(result);
        }       

        public IActionResult ProductDetails(int productId)
        {
            Coffee c = context.Coffees.FirstOrDefault(c => c.Id == productId);
            return View(c);
        }
    }
}
