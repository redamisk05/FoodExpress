
using Microsoft.AspNetCore.Mvc;

namespace FoodExpress.Controllers
{
    public class MealsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            if (id == 1)
            {
                ViewBag.Name = "Classic Burger";
                ViewBag.Price = 8.99;
                ViewBag.Description = "Beef patty, cheddar cheese, lettuce, tomato and special sauce.";
                ViewBag.Image = "burger.png";
            }
            else if (id == 2)
            {
                ViewBag.Name = "Pepperoni Pizza";
                ViewBag.Price = 12.99;
                ViewBag.Description = "Pizza with cheese and pepperoni.";
                ViewBag.Image = "Pizza.png";
            }
            else if (id == 3)
            {
                ViewBag.Name = "Grilled Chicken";
                ViewBag.Price = 11.99;
                ViewBag.Description = "Grilled chicken with vegetables.";
                ViewBag.Image = "chicken.png";
            }
            else if (id == 4)
            {
                ViewBag.Name = "Pasta Bolognese";
                ViewBag.Price = 10.99;
                ViewBag.Description = "Pasta with tomato and meat sauce.";
                ViewBag.Image = "pasta.png";
            }
            else
            {
                return NotFound();
            }

            return View();
        }
    }
}
