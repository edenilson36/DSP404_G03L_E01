using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaPedidosRestaurante.Models
{
    public class Pedido
    {
        public int PedidoId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public List<Menu> Platos { get; set; }  
        public string FormaPago { get; set; }
        public string Estado { get; set; }
        public decimal Total { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaPedido { get; set; }
    }
}