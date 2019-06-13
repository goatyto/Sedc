using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sedc.FormValidation.WebApp.Models;

namespace Sedc.FormValidation.WebApp.Controllers
{
    public class PizzaController : Controller
    {
        private SelectList PizzaStyles { get; set; }

        public PizzaController()
        {
            PizzaStyles = new SelectList(new []
            {
                "Neapolitan",
                "New Heaven",
                "Grandma Style",
                "New York Style",
                "Pan Style",
            });
        }

        public IActionResult AddPizza()
        {
            ViewBag.PizzaStyles = PizzaStyles;

            return View(new Pizza());
        }

        [HttpPost]
        public IActionResult AddPizza(Pizza pizza)
        {
            ViewBag.PizzaStyles = PizzaStyles;

            if (ModelState.IsValid)
            {
                ViewBag.Message = $"Successfully added {pizza.Name}";
                return View(new Pizza());
            }

            return View(pizza);
        }
    }
}