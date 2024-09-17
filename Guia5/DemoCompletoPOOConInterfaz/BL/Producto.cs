﻿namespace BL
{
    public class Producto
    {
        public int ID { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public float Cantidad { get; set; }
        public decimal Valor { get { return Precio * (decimal)Cantidad;  } }
    }
}
