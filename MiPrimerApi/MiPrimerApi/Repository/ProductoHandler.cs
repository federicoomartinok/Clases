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

    }
}
