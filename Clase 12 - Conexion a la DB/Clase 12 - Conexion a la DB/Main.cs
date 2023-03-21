using System;
using System.Data;
using System.Data.SqlClient;

namespace EjemploDeClase
{
    public class ProbarMain
    {
        static void Main(string[] args)
        {
            ProductoHandler productoHandler = new ProductoHandler();

            productoHandler.GetProductos();

            /*
            List<string> descripciones = productoHandler.GetTodasLasDescripcionesConReader();

            foreach (var descripcion in descripciones)
            {
                Console.WriteLine(descripcion);
            }*/
        }
    }
}
