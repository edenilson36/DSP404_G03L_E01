using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SistemaVentaEntradasApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        // Constructor que especifica la cadena de conexión
        public ApplicationDbContext() : base("SistemaVentaEntradasDB") { }

        // DbSets para cada entidad
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Concierto> Conciertos { get; set; }
        public DbSet<Localidad> Localidades { get; set; }
        public DbSet<Entrada> Entradas { get; set; }
    }
}
