using MiPrimerApi.Model;
using System.Data;
using System.Data.SqlClient;

namespace MiPrimerApi.Repository
{
    public static class ProductoHandler
    {
        public const string ConnectionString = "Server = 10.108.30.15; Database=[SistemaGestion];UID=testuser;PWD=qwertu";

        public static List<Producto> GetProductos()
        {
            List<Producto> resultado = new List<Producto>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlCommand.Connection.Open();
                    sqlCommand.CommandText = "SELECT * FROM Producto;";

                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();

                    sqlDataAdapter.SelectCommand = sqlCommand;

                    DataTable table = new DataTable();
                    sqlDataAdapter.Fill(table);
                    sqlCommand.Connection.Close();


                    foreach (DataRow row in table.Rows)
                    {
                        Producto producto = new Producto();
                        producto.Id = Convert.ToInt32(row["Id"]);
                        producto.Stock = Convert.ToInt32(row["Stock"]);
                        producto.IdUsuario = Convert.ToInt32(row["IdUsuario"]);
                        producto.Costo = Convert.ToInt32(row["Costo"]);
                        producto.PrecioDeVenta = Convert.ToInt32(row["PrecioDeVenta"]);
                        producto.Descripciones = row["Descripciones"].ToString();

                        resultado.Add(producto);
                    }
                }
            }

            return resultado;

        }

        public static bool EliminarProducto(int id)
        {
            bool resultado = false;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryDelete = "DELETE FROM Producto WHERE Id = @id";

                SqlParameter sqlParameter = new SqlParameter("id", System.Data.SqlDbType.BigInt);
                sqlParameter.Value = id;

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryDelete, sqlConnection))
                {
                    sqlCommand.Parameters.Add(sqlParameter);
                    int numberOfRows = sqlCommand.ExecuteNonQuery();

                    if (numberOfRows > 0)
                    {
                        resultado = true;
                    }
                }

                sqlConnection.Close();

            }
            return resultado;

        }

        public static bool ModificarNombreDeProducto(Producto producto)
        {
            bool resultado = false;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryInsert = "UPDATE Producto " +
                    "SET Descripciones = @descripciones " +
                    "WHERE Id = @id";


                SqlParameter descripcionParameter = new SqlParameter("@descripciones", System.Data.SqlDbType.VarChar) { Value = producto.Descripciones };
                SqlParameter idParameter = new SqlParameter("@id", System.Data.SqlDbType.BigInt) { Value = producto.Id };

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryInsert, sqlConnection))
                {
                    sqlCommand.Parameters.Add(descripcionParameter);
                    sqlCommand.Parameters.Add(idParameter);

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

        public static bool CrearProducto(Producto producto)
        {
            bool resultado = false;

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryInsert = "INSERT INTO Producto" +
                    "(Descripciones, Costo, PrecioVenta, Stock, IdUsuario) VALUES " +
                    "(@descripcionesParameter, @costoParameter, @precioVentaParameter, @stockParameter, @idUsuarioParameter);";


                SqlParameter descripcionesParameter = new SqlParameter("@descripcionesParameter", System.Data.SqlDbType.VarChar) { Value = producto.Descripciones };
                SqlParameter costoParameter = new SqlParameter("@costoParameter", System.Data.SqlDbType.VarChar) { Value = producto.Costo };
                SqlParameter precioVentaParameter = new SqlParameter("@precioVentaParameter", System.Data.SqlDbType.VarChar) { Value = producto.PrecioDeVenta };
                SqlParameter stockParameter = new SqlParameter("@stockParameter", System.Data.SqlDbType.VarChar) { Value = producto.Stock };
                SqlParameter idUsuarioParameter = new SqlParameter("@idUsuarioParameter", System.Data.SqlDbType.VarChar) { Value = producto.IdUsuario };


                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryInsert, sqlConnection))
                {
                    sqlCommand.Parameters.Add(descripcionesParameter);
                    sqlCommand.Parameters.Add(costoParameter);
                    sqlCommand.Parameters.Add(precioVentaParameter);
                    sqlCommand.Parameters.Add(stockParameter);
                    sqlCommand.Parameters.Add(idUsuarioParameter);

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
