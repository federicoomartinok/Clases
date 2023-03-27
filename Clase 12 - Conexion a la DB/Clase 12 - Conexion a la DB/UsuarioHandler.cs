using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EjemploDeClase
{
    public class UsuarioHandler : DbHandler
    {
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Usuario ", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {   
                                Usuario usuario = new Usuario();

                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Contraseña = dataReader["Contraseña"].ToString();
                                usuario.Mail = dataReader["Mail"].ToString();

                                usuarios.Add(usuario);
                            }
                        }
                    }
                    sqlConnection.Close();
                }

            }
            return usuarios;
        }

        public void Delete()
        {
            try
            {
                ///deberia recibir por parametros el id que desea borrar
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    string queryDelete = "DELETE FROM Usuario WHERE Id = @idUsuario";

                    double id = 1;
                    SqlParameter parametro = new SqlParameter();

                    parametro.ParameterName = "idUsuario";
                    parametro.SqlDbType = System.Data.SqlDbType.BigInt;
                    parametro.Value = id;

                    using (SqlCommand sqlCommand = new SqlCommand(queryDelete,sqlConnection))
                    {
                        sqlCommand.Parameters.Add(parametro);

                        ///devuelve las cantidad de filas afectadas con el executeNonQuery
                        int filasAfectadas = sqlCommand.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }           
            
        }


        public void UpdateContraseña()
        {
            try
            {
                ///deberia recibir por parametros el id que desea borrar
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    string queryUpdate = "UPDATE Usuario SET Contraseña = @nuevaContraseña WHERE Id = @idUsuario;";

                    double id = 1;
                    string nuevaContraseña = "ContraseñaNueva123";

                    SqlParameter parametroNuevaContraseña = new SqlParameter();

                    parametroNuevaContraseña.ParameterName = "nuevaContraseña";
                    parametroNuevaContraseña.SqlDbType = System.Data.SqlDbType.VarChar;
                    parametroNuevaContraseña.Value = nuevaContraseña;

                    SqlParameter parametroUsuarioId = new SqlParameter();

                    parametroUsuarioId.ParameterName = "idUsuario";
                    parametroUsuarioId.SqlDbType = System.Data.SqlDbType.BigInt;
                    parametroUsuarioId.Value = id;

                    using (SqlCommand sqlCommand = new SqlCommand(queryUpdate,sqlConnection))
                    {
                        sqlCommand.Parameters.Add(parametroNuevaContraseña);
                        sqlCommand.Parameters.Add(parametroUsuarioId);


                        ///devuelve las cantidad de filas afectadas con el executeNonQuery
                        sqlConnection.Open();
                        int filasAfectadas = sqlCommand.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        public void Insert()
           ///Aca es la forma correcta de crear un metodo de insert con SQL para que no te rompa todo
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    Console.Write("Ingrese el nombre: ");
                    string nombre = Console.ReadLine();

                    Console.Write("Ingrese el apellido: ");
                    string apellido = Console.ReadLine();

                    Console.Write("Ingrese el nombre de usuario: ");
                    string nombreUsuario = Console.ReadLine();

                    Console.Write("Ingrese la contraseña: ");
                    string contraseña = Console.ReadLine();

                    Console.Write("Ingrese el correo electrónico: ");
                    string correo = Console.ReadLine();

                    string queryInsert = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) " +
                        "VALUES (@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

                    sqlConnection.Open();

                    using (SqlCommand sqlCommand = new SqlCommand(queryInsert, sqlConnection))
                    {
                        sqlCommand.Parameters.AddWithValue("@Nombre", nombre);
                        sqlCommand.Parameters.AddWithValue("@Apellido", apellido);
                        sqlCommand.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                        sqlCommand.Parameters.AddWithValue("@Contraseña", contraseña);
                        sqlCommand.Parameters.AddWithValue("@Mail", correo);

                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }






            /*try
            {
                ///deberia recibir por parametros el id que desea borrar
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    string queryInsert = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail)" +
                        " VALUES ('Rodrigo','Perez','rperez','MyNuevaPw123','RPerez@gmail.com'";

                    sqlConnection.Open();


                    using (SqlCommand sqlCommand = new SqlCommand(queryInsert, sqlConnection))
                    {
                    
                        sqlCommand.ExecuteScalar();
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }*/

        }
    }
}
