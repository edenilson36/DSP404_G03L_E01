using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.UI.WebControls;

namespace SistemaPedidosRestaurante.Models
{
    public class DespachoPedidosContext : DbContext
    {
        // Constructor que define la conexión a la base de datos
        public DespachoPedidosContext() : base("name=DespachoPedidosDB")
        {
        }

        // DbSets que representan las tablas en la base de datos
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
    }
}