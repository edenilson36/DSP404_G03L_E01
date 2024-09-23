using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaPedidosRestaurante.Models
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }  
        public string Nombre { get; set; }  
        public string Puesto { get; set; }  
        public List<Pedido> Pedidos { get; set; }  
    }
}