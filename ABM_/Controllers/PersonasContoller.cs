
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
        public IActionResult Add()
        {
            //le paso el nombre de la vista
            return View("Add");
        }
        public IActionResult Delete()
        {
            //le paso el nombre de la vista
            return View("Delete");
        }
        public IActionResult Change()
        {
            //le paso el nombre de la vista
            return View("Change");
        }
    }
}
