using Microsoft.AspNetCore.Mvc;

namespace Sedc.AttributeRouting.WebApp.Controllers
{
    [Route("pizzas")]
    public class PizzaController : Controller
    {
        [Route("menu", Name = "menu")]
        public IActionResult Menu()
        {
            return View();
        }

        [Route("offers", Name = "offers")]
        public IActionResult Offers()
        {
            return View();
        }
    }
}