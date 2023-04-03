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
            
            /// para llamar a get usuario tengo que crear una lista de usuarios para y almacenarlos
            UsuarioHandler usuarioHandler = new UsuarioHandler();

            ///usuarioHandler.UpdateContraseña();

            usuarioHandler.Insert();
            List<Usuario> usuarios = usuarioHandler.GetUsuarios();

            /// un for que recorre los usuarios y me los devuelve por consola
            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine($"Id: {usuario.Id}, Nombre de usuario: {usuario.NombreUsuario}, Contraseña: {usuario.Contraseña}");
            }



            /*
            List<string> descripciones = productoHandler.GetTodasLasDescripcionesConReader();

            foreach (var descripcion in descripciones)
            {
                Console.WriteLine(descripcion);
            }*/
        }
    }
}


