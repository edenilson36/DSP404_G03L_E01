using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SistemaPedidosRestaurante.Models;

namespace SistemaPedidosRestaurante.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        // Acción para mostrar los pedidos
        public ActionResult Pedidos()
        {
            return View();
        }

        [HttpPost]
        public ActionResult ActualizarPedido(string estado, string comentarios, int pedidoId)
        {
            return RedirectToAction("GestionarPedidos");
        }

        public ActionResult GestionarPedidos()
        {
            var pedidos = new List<Pedido>
    {
        new Pedido
        {
            Platos = new List<Menu>
            {
                new Menu { Nombre = "Plato 1", Precio = 10 },
                new Menu { Nombre = "Plato 3", Precio = 20 }
            },
            Total = 30,
            Estado = "Aceptado",
            Comentarios = "Añadir más salsa"
        },
        new Pedido
        {
            Platos = new List<Menu>
            {
                new Menu { Nombre = "Plato 2", Precio = 15 }
            },
            Total = 15,
            Estado = "En proceso de elaborar",
            Comentarios = "Sin cebolla"
        }
    };

            return View(pedidos);  
        }
    }
}