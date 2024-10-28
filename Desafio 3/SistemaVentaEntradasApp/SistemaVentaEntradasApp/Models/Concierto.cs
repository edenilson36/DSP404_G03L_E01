using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema; // Importante para [Table] attribute

namespace SistemaVentaEntradasApp.Models
{
    [Table("Conciertos")]
    public class Concierto
    {
        public int ConciertoID { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }

        // Relación uno a muchos con la tabla Localidades
        public ICollection<Localidad> Localidades { get; set; }
    }
}