using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SistemaPedidosRestaurante.Controllers
{
    public class ClienteController : Controller
    {



        // GET: Cliente
        // Acción para mostrar el menú
        public ActionResult Menu()
        {
            return View();
        }

        // POST: Cliente/ResumenCompra
        [HttpPost]
        public ActionResult ResumenCompra(string[] platos)
        {
            
            ViewBag.PlatosSeleccionados = platos;

            return View();
        }

      
        [HttpPost]
        public ActionResult ConfirmarPago(string[] platosSeleccionados, string formaPago)
        {
            
            ViewBag.PlatosSeleccionados = platosSeleccionados;
            ViewBag.FormaPago = formaPago;

           
            return View("ConfirmacionPago");
        }

        // GET: Cliente/Historial
        public ActionResult Historial()
        {
         
            var pedidos = new List<Pedido>
        {
            new Pedido { Platos = new string[] { "Plato 1", "Plato 3" }, Total = 30, Estado = "En preparación", Comentarios = "Añadir más salsa" },
            new Pedido { Platos = new string[] { "Plato 2" }, Total = 15, Estado = "Listo", Comentarios = "Sin cebolla" }
        };

            ViewBag.Pedidos = pedidos;
            return View();
        }

        public class Pedido
        {
            public string[] Platos { get; set; }
            public decimal Total { get; set; }
            public string Estado { get; set; }
            public string Comentarios { get; set; }
        }
    }
}