using Microsoft.AspNetCore.Mvc;
using SistemaWebMisRecetas.Data;
using SistemaWebMisRecetas.Models;
using System.Collections.Generic;
using System.Linq;

namespace SistemaWebMisRecetas.Controllers
{
    public class RecetaController : Controller
    {
        private readonly DBRecetasContext context;
        public RecetaController(DBRecetasContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var recetas = context.Recetas.ToList();
            return View(recetas);
        }

        [HttpGet]
        public ActionResult Create() 
        {
            Receta receta= new Receta();
            return View("Create", receta);
        }

        [HttpPost]
        public ActionResult Create(Receta receta)
        {
            if (ModelState.IsValid)
            {
                context.Recetas.Add(receta);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(receta);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Receta receta = context.Recetas.Find(id);

            if(receta== null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", receta);
            }
        }

        [HttpGet("{nombreAutor}")]
        public ActionResult<IEnumerable<Receta>> ByNombreAutor(string nombreAutor)
        {
            var autor = (from a in context.Recetas
                            where a.NombreAutor == nombreAutor
                            select a).ToList();
            return View("ByNombreAutor", autor);

        }
    }
}
