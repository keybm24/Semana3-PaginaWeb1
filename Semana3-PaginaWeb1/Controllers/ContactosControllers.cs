using Microsoft.AspNetCore.Mvc;
using Semana3_PaginaWeb1.Models;

namespace Semana3_PaginaWeb1.Controllers {
    public class ContactosControllers : Controller {
        List<DatosContacto> datos = new List<DatosContacto>() {
                        new DatosContacto () {Correo = "keybarmor24@gmail.com",
                            Nombre = "Keilyn"},
                        new DatosContacto () {Correo = "kbitabarrantesm.com",
                            Nombre = "Angelica"},
                        new DatosContacto () {Correo = "kbarrantesm@edu.upolitecnica.cr",
                            Nombre = "Bita"},
        };
        public IActionResult Index() {
            return View(datos);
            }
    }
}
