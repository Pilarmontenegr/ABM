
using ABM_.Data;
using ABM_.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

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
            return View("Add");
        }
        //POST
        [HttpPost] //este metodo agarra la acción POST
        public async Task<IActionResult> Create(Persona persona)
        {
            try //para manejar errores y excepciones
            {    
                //para agregar los datos recibidos
                _context.Add(persona);
                await _context.SaveChangesAsync();
                                               //Retorna los nuevos datos a la vista que muestra las personas
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                throw;
            }
        }




        public IActionResult Delete()
        {
            //le paso el nombre de la vista
            return View();
        }
        //public IActionResult Edit(int id)
        //{   //preguntamos si existe el id 
        //    if (_context.Personas.Any(x => x.Id == id))
        //    {    //si existe lo recuperamos de la bd
        //        Persona modelo = _context.Personas.Select(p => new Persona
        //        {
        //            Id = p.Id,
        //            Nombre = p.Nombre,
        //            Apellido = p.Apellido,
        //            Dni = p.Dni,
        //            Domicilio = p.Domicilio,
        //            Edad = p.Edad
        //        }).First(x => x.Id == id);

        //        return View(modelo);
        //    }
            //lo redireccionamos al axion error del controller home
            //return RedirectToAction("Error", "Home");
        //}


    }
}


