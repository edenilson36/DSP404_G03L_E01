using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaVentaEntradasApp.Models;

namespace SistemaVentaEntradasApp.Controllers
{
    public class EntradasController : Controller
    {
        // Instancia del contexto de base de datos
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Entradas/Create
        public ActionResult Create(int conciertoId)
        {
            // Obtener las localidades disponibles para el concierto seleccionado
            var localidades = db.Localidades.Where(l => l.ConciertoID == conciertoId).ToList();
            ViewBag.ConciertoID = conciertoId;
            ViewBag.LocalidadID = new SelectList(localidades, "LocalidadID", "TipoLocalidad"); // Asegúrate de esta línea

            // Mostrar el formulario de compra
            return View();
        }


        // POST: Entradas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(int conciertoId, Entrada entrada)
        {
            if (ModelState.IsValid)
            {
                var localidad = db.Localidades.Find(entrada.LocalidadID);
                var conciertoExists = db.Conciertos.Any(c => c.ConciertoID == conciertoId);
                var usuarioExists = db.Usuarios.Any(u => u.UsuarioID == entrada.UsuarioID);

                // Verificar que el concierto, la localidad y el usuario existen
                if (!conciertoExists || localidad == null || !usuarioExists)
                {
                    ModelState.AddModelError("", "Datos inválidos. Verifique que el concierto, la localidad y el usuario existan.");
                    return View(entrada);
                }

                // Validar la disponibilidad de la cantidad de entradas solicitada
                if (localidad.CantidadDisponible >= entrada.Cantidad)
                {
                    entrada.FechaCompra = DateTime.Now;
                    entrada.TotalPago = entrada.Cantidad * localidad.Precio;
                    entrada.ConciertoID = conciertoId;

                    localidad.CantidadDisponible -= entrada.Cantidad;
                    db.Entradas.Add(entrada);
                    db.SaveChanges();

                    return RedirectToAction("Index", "Conciertos");
                }
                else
                {
                    ModelState.AddModelError("", "No hay suficientes entradas disponibles en la localidad seleccionada.");
                }
            }

            var localidades = db.Localidades.Where(l => l.ConciertoID == conciertoId).ToList();
            ViewBag.ConciertoID = conciertoId;
            ViewBag.LocalidadID = new SelectList(localidades, "LocalidadID", "TipoLocalidad", entrada.LocalidadID);
            return View(entrada);
        }

        // Histórico de entradas compradas por el usuario
        public ActionResult Historico()
        {
            if (Session["UsuarioID"] == null)
            {
                return RedirectToAction("Login", "Cuenta");
            }

            int usuarioId = (int)Session["UsuarioID"];
            var entradas = db.Entradas
                            .Include("Concierto")
                            .Include("Localidad")
                            .Where(e => e.UsuarioID == usuarioId)
                            .ToList();
            return View(entradas);
        }


        // Vista de compras de eventos (entradas)
        public ActionResult Compras()
        {
            int usuarioId = (int)Session["UsuarioID"];
            var compras = db.Entradas.Include("Concierto").Where(e => e.UsuarioID == usuarioId).ToList();
            return View(compras);
        }

        // Liberar los recursos del contexto de datos
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
