using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaVentaEntradasApp.Models;

namespace SistemaVentaEntradasApp.Controllers
{
    public class LocalidadesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Localidades
        public ActionResult Index()
        {
            var localidades = db.Localidades.Include("Concierto").ToList();
            return View(localidades);
        }

        // GET: Localidades/Create
        public ActionResult Create()
        {
            ViewBag.ConciertoID = new SelectList(db.Conciertos, "ConciertoID", "Nombre");
            return View();
        }

        // POST: Localidades/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Localidad localidad)
        {
            if (ModelState.IsValid)
            {
                db.Localidades.Add(localidad);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ConciertoID = new SelectList(db.Conciertos, "ConciertoID", "Nombre", localidad.ConciertoID);
            return View(localidad);
        }

        // Aquí puedes agregar métodos para Edit, Details y Delete si los necesitas
    }
}