using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaVentaEntradasApp.Models;

namespace SistemaVentaEntradasApp.Controllers
{
    public class CuentaController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // Acción para mostrar el formulario de registro
        public ActionResult Register()
        {
            return View();
        }

        // Acción POST para registrar al usuario
        [HttpPost]
        public ActionResult Register(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                // Agregar usuario a la base de datos
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(usuario);
        }

        // Acción para mostrar el formulario de inicio de sesión
        public ActionResult Login()
        {
            return View();
        }

        // Acción POST para autenticar al usuario
        [HttpPost]
        public ActionResult Login(string correo, string contrasena)
        {
            var usuario = db.Usuarios.FirstOrDefault(u => u.Correo == correo && u.Contrasena == contrasena);
            if (usuario != null)
            {
                Session["UsuarioID"] = usuario.UsuarioID;
                Session["Nombre"] = usuario.Nombre;
                return RedirectToAction("Dashboard", "Home");
            }
            ModelState.AddModelError("", "Correo o contraseña incorrectos.");
            return View();
        }

        // Acción para cerrar sesión
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }
    }
}