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
    }
}
