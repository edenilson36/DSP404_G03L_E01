using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SistemaVentaEntradasApp.Models
{
    [Table("Localidades")] // Vincula el modelo a la tabla "Localidades"
    public class Localidad
    {
        public int LocalidadID { get; set; }
        public int ConciertoID { get; set; }
        public string TipoLocalidad { get; set; }
        public decimal Precio { get; set; }
        public int CantidadDisponible { get; set; }

        // Relación con la tabla Concierto
        public Concierto Concierto { get; set; }
    }

}