using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaPedidosRestaurante.Controllers
{
    public class LoginController : Controller 
    {
 
        public ActionResult LoginCliente()
        {
            return View();
        }

        public ActionResult LoginEmpleado()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginCliente(string usuario, string contraseña)
        {
            if (usuario == "cliente" && contraseña == "1234")
            {
                return RedirectToAction("Menu", "Cliente"); 
            }
            ViewBag.Error = "Credenciales incorrectas";
            return View();
        }

        // Procesa el login del empleado
        [HttpPost]
        public ActionResult LoginEmpleado(string usuario, string contraseña)
        {
            if (usuario == "empleado" && contraseña == "abcd")
            {
                return RedirectToAction("GestionarPedidos", "Empleado"); 
            }
            ViewBag.Error = "Credenciales incorrectas";
            return View();
        }
    }
}
