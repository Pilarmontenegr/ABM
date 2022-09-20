
using Microsoft.AspNetCore.Mvc;

namespace ABM_.Controllers
{
    public class PersonasController : Controller
    {
       

        public IActionResult Index()
        {
            //le paso el nombre de la vista
            return View("Personas");
        }
    }
}
