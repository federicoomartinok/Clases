using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

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

        public void Delete(Usuario usuario) //Este delete recibe un usuario como parametro
        {
            try
            {
                ///deberia recibir por parametros el id que desea borrar
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    string queryDelete = "DELETE FROM Usuario WHERE Id = @idUsuario";

                    SqlParameter parametro = new SqlParameter();

                    parametro.ParameterName = "idUsuario";
                    parametro.SqlDbType = System.Data.SqlDbType.BigInt;
                    parametro.Value = usuario.Id;

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
    

        public void UpdateContraseña(Usuario usuario)
        {
            try
            {
                ///deberia recibir por parametros el id que desea borrar
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    string queryUpdate = "UPDATE Usuario SET Contraseña = @nuevaContraseña WHERE Id = @idUsuario;";

                    double id = 1;

                    SqlParameter parametroNuevaContraseña = new SqlParameter();

                    parametroNuevaContraseña.ParameterName = "nuevaContraseña";
                    parametroNuevaContraseña.SqlDbType = System.Data.SqlDbType.VarChar;
                    parametroNuevaContraseña.Value = usuario.Contraseña;

                    SqlParameter parametroUsuarioId = new SqlParameter();

                    parametroUsuarioId.ParameterName = "idUsuario";
                    parametroUsuarioId.SqlDbType = System.Data.SqlDbType.BigInt;
                    parametroUsuarioId.Value = usuario.Id;

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
        public void Insert(Usuario usuario)
           ///Aca es la forma correcta de crear un metodo de insert con SQL para que no te rompa todo y lo agrega en la DB
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
                {
                    
                    string queryInsert = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) " +
                        "VALUES ('Ramiro', 'Rodriguez','RamRodriguez','Rrodriguez123', 'Rrodriguez@gmail.com')";


                                      
                    SqlParameter nombreParameter = new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre };
                    SqlParameter apellidoParameter = new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido };
                    SqlParameter nombreUsuarioParameter = new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario };
                    SqlParameter contraseñaParameter = new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña };
                    SqlParameter mailParameter = new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail };

                    sqlConnection.Open();


                    using (SqlCommand sqlCommand = new SqlCommand(queryInsert, sqlConnection))
                    {
                        sqlCommand.Parameters.Add(nombreParameter);
                        sqlCommand.Parameters.Add(apellidoParameter);
                        sqlCommand.Parameters.Add(nombreUsuarioParameter);
                        sqlCommand.Parameters.Add(contraseñaParameter);
                        sqlCommand.Parameters.Add(mailParameter);

                        sqlCommand.ExecuteNonQuery();
                    }

                    sqlConnection.Close();
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
