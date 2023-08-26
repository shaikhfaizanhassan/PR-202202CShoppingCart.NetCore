using Microsoft.AspNetCore.Mvc;
using Shopping_cart.Models;

namespace Shopping_cart.Controllers
{
    public class HomeController : Controller
    {
        private readonly ShopDbContext db;

        public HomeController(ShopDbContext db)

        {
            //demo
            this.db = db;
        }
        public IActionResult Index()
        {
            var getproduct = db.products.ToList();
            return View(getproduct);
        }
    }
}
