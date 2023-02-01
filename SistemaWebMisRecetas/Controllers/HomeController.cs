using Microsoft.AspNetCore.Mvc;
using System;

namespace SistemaWebMisRecetas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Nombre = "Mis Recetas";
            ViewBag.Fecha = DateTime.Now.ToString();
            return View();
        }

    }
}
