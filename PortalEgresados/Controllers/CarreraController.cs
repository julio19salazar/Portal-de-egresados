using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortalEgresados.Controllers
{
    //nombre corregido
    public class CarreraController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet()]
        public IActionResult Agregar()
        {
            return View();
        }
        [HttpPost()]
        //Falta el modelo, por ende puse un parametro para que no marcara error.
        public IActionResult Agregar(Object carrera)
        {
            return View();
        }
        [HttpGet()]
        public IActionResult Editar()
        {
            return View();
        }
        [HttpPost()]
        //Falta el modelo, por ende puse un parametro para que no marcara error.
        public IActionResult Editar(Object carrera)
        {
            return View();
        }
        public IActionResult Eliminar()
        {
            return View();
        }
        [HttpPost()]
        //Falta el modelo, por ende puse un parametro para que no marcara error.
        public IActionResult Eliminar(Object carrera)
        {
            return View();
        }

    }
}
