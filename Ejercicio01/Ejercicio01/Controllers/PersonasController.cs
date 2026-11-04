using Microsoft.AspNetCore.Mvc;

namespace Ejercicio01.Controllers
{
    public class PersonasController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
