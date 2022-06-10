using Microsoft.AspNetCore.Mvc;
using Semana3_PaginaWeb1.Models;
using System.Diagnostics;

namespace Semana3_PaginaWeb1.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger) {
            _logger = logger;
        }

        public IActionResult Index() {
            return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        public IActionResult Contactenos() {
            //DatosContacto dc = new DatosContacto();
            //dc.Nombre = "Keilyn";
            //dc.Correo = "kbitabarrantesm@hotmail.com";
            //dc.Comentario = "esta bien cool esto";
            return View(); 
        }

        //atributo delo metodo que es para enviar el formulario
        [HttpPost]
        public IActionResult Contactenos(DatosContacto DC) {
            DC.Comentario = "Comentario Generico";
            return View("ContactenosGracias", DC);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]

        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}