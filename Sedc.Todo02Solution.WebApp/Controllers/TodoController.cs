using Microsoft.AspNetCore.Mvc;

namespace Sedc.Todo02Solution.WebApp.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}