using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Sedc.SimpleForm.WebApp.Models;

namespace Sedc.SimpleForm.WebApp.Controllers
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
            ViewBag.Message = $"Successfully added {pizza.Name}";

            return View(new Pizza());
        }
    }
}