using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaVentaEntradasApp.Models;

namespace SistemaVentaEntradasApp.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext(); // Instancia del contexto de base de datos

        public ActionResult Dashboard()
        {
            if (Session["UsuarioID"] == null)
            {
                return RedirectToAction("Login", "Cuenta");
            }

            // Obtén la lista de conciertos y envíala a la vista
            var conciertos = db.Conciertos.ToList();
            return View(conciertos);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}