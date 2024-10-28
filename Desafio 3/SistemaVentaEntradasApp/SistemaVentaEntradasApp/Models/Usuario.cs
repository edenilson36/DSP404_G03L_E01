using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaVentaEntradasApp.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
    }
}