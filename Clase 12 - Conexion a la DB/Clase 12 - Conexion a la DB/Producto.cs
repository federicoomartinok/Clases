﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EjemploDeClase
{

    public class Producto
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
        public int Costo { get; set; }
        public string Descripciones { get; set; }
        public double PrecioDeCompra { get; set; }
        public double PrecioDeVenta { get; set; }
        public string Categoria { get; set; }

    }

    
}


