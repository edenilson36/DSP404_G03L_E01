using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CajeroWeb.Controllers
{
    public class SaldoController : Controller
    {
        // GET: Saldo
        public ActionResult Verificar(string numeroTarjeta, double saldo)
        {
            // Pasamos los datos al ViewBag para que se muestren en la vista
            ViewBag.NumeroTarjeta = numeroTarjeta;
            ViewBag.Saldo = saldo;

            return View();
        }

        // GET: Saldo
        public ActionResult Index()
        {
            return View();
        }
    }
}