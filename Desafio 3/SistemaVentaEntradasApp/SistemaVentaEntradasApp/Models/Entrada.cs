using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVentaEntradasApp.Models
{
    public class Entrada
    {
        public int EntradaID { get; set; }
        public int UsuarioID { get; set; }
        public int ConciertoID { get; set; }
        public int LocalidadID { get; set; }
        public DateTime FechaCompra { get; set; } = DateTime.Now;
        public int Cantidad { get; set; }
        public decimal TotalPago { get; set; }

        // Relaciones con las tablas Usuario, Concierto y Localidad
        public Usuario Usuario { get; set; }
        public Concierto Concierto { get; set; }
        public Localidad Localidad { get; set; }
    }

}