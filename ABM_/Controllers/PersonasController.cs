
using ABM_.Data;
using ABM_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ABM_.Controllers
{
    public class PersonasController : Controller
    {

        private readonly ApplicationDbContext _context;

        public PersonasController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {

            //llamo al _contex
            var personas = _context.Personas.ToList();
            //le paso el nombre de la vista
            //habiamos puesto ,personas//
            return View("Persona",personas);
        }
        public IActionResult Add()
        {
            //le paso el nombre de la vista
            return View();
        }
        public IActionResult Delete()
        {
            //le paso el nombre de la vista
            return View();
        }
        public IActionResult Change()
        {
            //le paso el nombre de la vista
            return View();
        }


    }
}


