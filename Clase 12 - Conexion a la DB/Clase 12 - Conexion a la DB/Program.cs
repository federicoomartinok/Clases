using System.Data.SqlClient;

namespace EjemploDeClase
{

    public class ProductoHandler
    {
        public const string ConnectionString = "Server=tcp:10.108.30.15;" +
            "Database=SistemaGestion;" +
            "Trusted_Connection=True" +
            "User ID=testuser" +
            "Password=qwertu";


        public void AbrirYCerrarConexion()
        {

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand(
                    "SELECT * FROM Producto WHERE Id = @idProducto", sqlConnection)) //Toma por parametro la query el sqlconnection
                {
                    ///int idProducto = 3;
                    sqlConnection.Open();

                    SqlParameter parametro = new SqlParameter();

                    /*parametro.ParameterName = "idProducto";
                    parametro.SqlDbType = System.Data.SqlDbType.Int;
                    parametro.Value = idProducto;

                    sqlCommand.Parameters.Add(parametro);*/

                    using (SqlDataReader datareader = sqlCommand.ExecuteReader())
                    {
                        if (datareader.HasRows)
                        {
                            while (datareader.Read())
                            {
                                string dato = datareader.GetString(1);
                            }
                        }
                    }

                    sqlConnection.Close();

                }                                   

            }            
                       
        }

    }

}

