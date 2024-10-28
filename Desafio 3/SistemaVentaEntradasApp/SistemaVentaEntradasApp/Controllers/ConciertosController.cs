using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaVentaEntradasApp.Models; // Importar el espacio de nombres del modelo y el contexto de datos

namespace SistemaVentaEntradasApp.Controllers
{
    public class ConciertosController : Controller
    {
        // Instancia del contexto de base de datos
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Conciertos
        public ActionResult Index()
        {
            // Obtener la lista de conciertos y enviarla a la vista
            var conciertos = db.Conciertos.ToList();
            return View(conciertos);
        }

        // GET: Conciertos/Details/5
        public ActionResult Details(int id)
        {
            var concierto = db.Conciertos.Find(id);
            if (concierto == null)
            {
                return HttpNotFound();
            }
            return View(concierto);
        }

        // GET: Conciertos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Conciertos/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Concierto concierto)
        {
            if (ModelState.IsValid)
            {
                db.Conciertos.Add(concierto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(concierto);
        }

        // GET: Conciertos/Edit/5
        public ActionResult Edit(int id)
        {
            var concierto = db.Conciertos.Find(id);
            if (concierto == null)
            {
                return HttpNotFound(); // Si no encuentra el concierto, devuelve 404
            }
            return View(concierto);
        }


        // POST: Conciertos/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Concierto concierto)
        {
            if (ModelState.IsValid)
            {
                var existingConcierto = db.Conciertos.Find(concierto.ConciertoID);
                if (existingConcierto == null)
                {
                    return HttpNotFound(); // Si el concierto no existe, devuelve un error 404
                }

                // Actualiza las propiedades del registro existente
                existingConcierto.Nombre = concierto.Nombre;
                existingConcierto.Fecha = concierto.Fecha;
                existingConcierto.Lugar = concierto.Lugar;

                db.Entry(existingConcierto).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(concierto);
        }



        // GET: Conciertos/Delete/5
        public ActionResult Delete(int id)
        {
            var concierto = db.Conciertos.Find(id);
            if (concierto == null)
            {
                return HttpNotFound();
            }
            return View(concierto);
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
