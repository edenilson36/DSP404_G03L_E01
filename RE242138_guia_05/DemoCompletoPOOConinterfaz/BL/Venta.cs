using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Venta
    {
        private string cliente;
        private DateTime fecha;
        private List<Producto> productos;
        public Venta (string cliente)
        {
            this.cliente = cliente;
            this.fecha = DateTime.Now;
            this.Productos = new List<Producto>();


        }

        public List<Producto> Productos // Propiedad pública
        {
            get => productos;  // Devuelve el campo privado
            set => productos = value;  // Asigna el campo privado
        }

        public void agregarProducto(Producto producto)
        {
            Productos.Add(producto);

        }
        public decimal Total()
        {
            decimal Total = 0;
            foreach (Producto producto in Productos)
            {
                Total += producto.Valor;  
            }
            return Total;
        }
    }
}
