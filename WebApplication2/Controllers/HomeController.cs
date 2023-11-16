using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {


            List<Product> productsAdd = new List<Product>();
            productsAdd.Add(new Product()
            {
                Id = 1,
                Name = "Qalos",
                Price = 6.49,
                İmgUrl = "indir (3).jpeg"
            }); 
            productsAdd.Add(new Product()
            {
                Id = 2,
                Name = "Sort",
                Price = 10,
                İmgUrl = "images (1).jpeg"
            }); 
            productsAdd.Add(new Product()
            {
                Id = 3,
                Name = "Qalos",
                Price = 19.99,
                İmgUrl = "indir (2).jpeg"
            });
            productsAdd.Add(new Product()
            {
                Id= 4,
                Name = "Sort",
                Price=9.99,
                İmgUrl = "indir (1).jpeg"
            });



            return View(productsAdd);
        }
    }
}
