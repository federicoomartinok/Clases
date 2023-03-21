using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploDeClase
{
    
    public class Producto
    {
        public int Id;
        public int Stock;
        public int IdUsuario;
        public int Costo;
        public string Descripcion;
        public double PrecioDeCompra;
        public double PrecioDeVenta;
        public string Categoria;


        public Producto()
        {
            Id = 0;
            Stock = 0;
            IdUsuario = 0;
            Costo = 0;
            Descripcion = String.Empty;
            PrecioDeCompra = 0;
            PrecioDeVenta = 0;
            Categoria = String.Empty;
        }

        public Producto(int id,int stock, int idUsuario, int costo, string descripcion, double precioDeCompra,
            double precioDeVenta, string categoria)
        {
            Id = id;
            Stock = stock;
            IdUsuario = idUsuario;
            Costo = costo;
            Descripcion = descripcion;
            PrecioDeCompra = precioDeCompra;
            PrecioDeVenta = precioDeVenta;
            Categoria = categoria;
        }
    }

}
