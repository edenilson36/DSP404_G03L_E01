﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SistemaPedidosRestaurante.Models
{
    public class Cliente
    {
        public int ClienteId { get; set; }  
        public string Nombre { get; set; }  
        public string Apellido { get; set; } 
        public string Email { get; set; }  
    }
}