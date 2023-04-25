using MiPrimerApi.Model;
using System.Data.SqlClient;

namespace MiPrimerApi.Repository
{
    public static class UsuarioHandler
    {
        public const string ConnectionString = "Server = 10.108.30.15; Database=[SistemaGestion];UID=testuser;PWD=qwertu";

        public static List<Usuario>GetUsuarios()
        {
            List<Usuario> resultado = new List<Usuario>();

            using(SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Usuario", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if(dataReader.HasRows)
                        {
                            while(dataReader.Read())
                            {
                                Usuario usuario = new Usuario();

                                usuario.Id = Convert.ToInt32(dataReader["Id"]);
                                usuario.NombreUsuario = dataReader["NombreUsuario"].ToString();
                                usuario.Nombre = dataReader["Nombre"].ToString();
                                usuario.Apellido = dataReader["Apellido"].ToString();
                                usuario.Contraseña = dataReader["Contraseña"].ToString();
                                usuario.Mail = dataReader["Mail"].ToString();

                                resultado.Add(usuario);
                            }
                        }
                    }
                }
            }

            return resultado;
        }
        public static bool EliminarUsuario(int id)
        {
            bool resultado = false;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryDelete = "DELETE FROM Usuario WHERE Id = @id";

                SqlParameter sqlParameter = new SqlParameter("id", System.Data.SqlDbType.BigInt);
                sqlParameter.Value = id;

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryDelete, sqlConnection))
                {
                    sqlCommand.Parameters.Add(sqlParameter);
                    int numberOfRows = sqlCommand.ExecuteNonQuery();

                    if(numberOfRows > 0)
                    {
                        resultado = true;
                    }
                }

                sqlConnection.Close();
               
            }

            return resultado;

        }

        public static bool CrearUsuario(Usuario usuario)
        {
            bool resultado = false;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryInsert = "INSERT INTO [SistemaGestion].[dbo].[Usuario]" +
                    "(Nombre, Apellido, NombreUsuario, Contraseña, Mail) VALUES " +
                    "(@nombreParameter, @apellidoParameter, @nombreUsuarioParameter, @contraseñaParameter, @mailParameter);";


                SqlParameter nombreParameter = new SqlParameter("Nombre", System.Data.SqlDbType.VarChar) {Value = usuario.Nombre };
                SqlParameter apellidoParameter = new SqlParameter("Apellido", System.Data.SqlDbType.VarChar) { Value = usuario.Apellido };
                SqlParameter nombreUsuarioParameter = new SqlParameter("NombreUsuario", System.Data.SqlDbType.VarChar) { Value = usuario.NombreUsuario};
                SqlParameter contraseñaParameter = new SqlParameter("Contraseña", System.Data.SqlDbType.VarChar) { Value = usuario.Contraseña };
                SqlParameter mailParameter = new SqlParameter("Mail", System.Data.SqlDbType.VarChar) { Value = usuario.Mail };


                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryInsert, sqlConnection))
                {
                    sqlCommand.Parameters.Add(nombreParameter);
                    sqlCommand.Parameters.Add(apellidoParameter);
                    sqlCommand.Parameters.Add(nombreUsuarioParameter);
                    sqlCommand.Parameters.Add(contraseñaParameter);
                    sqlCommand.Parameters.Add(mailParameter);

                   int numeberOfRows = sqlCommand.ExecuteNonQuery(); // se ejecuta la sentencia sql

                    if (numeberOfRows > 0)
                    {
                        resultado = true;
                    }
                }

                sqlConnection.Close();
            }

            return resultado;
        }        
    }
}
