using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaPedidosRestaurante.Models
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
    }
}