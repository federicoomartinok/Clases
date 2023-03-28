using System;
using System.Data;
using System.Data.SqlClient;

namespace EjemploDeClase
{

    public class ProductoHandler : DbHandler
    {

        public List<Producto> GetProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Producto ", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                ///Le pido que me muestre lo que hay en la columna 2, osea la descrpicion
                                Producto producto = new Producto();
                                producto.Id = Convert.ToInt32(dataReader["Id"]);
                                producto.Stock = Convert.ToInt32(dataReader["Stock"]);
                                producto.IdUsuario = Convert.ToInt32(dataReader["IdUsuario"]);
                                producto.Costo = Convert.ToInt32(dataReader["Costo"]);

                                productos.Add(producto);
                            }
                        }
                    }
                    sqlConnection.Close();
                }

            }
            return productos;
        }
        public List<string> GetTodasLasDescripcionesConReader()
        {
            List<string> descripciones = new List<string>();

            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {        
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Producto ", sqlConnection))
                {
                    sqlConnection.Open();

                    using (SqlDataReader dataReader = sqlCommand.ExecuteReader())
                    {
                        if (dataReader.HasRows)
                        {
                            while (dataReader.Read())
                            {
                                ///Le pido que me muestre lo que hay en la columna 2, osea la descrpicion
                                descripciones.Add (dataReader.GetString(1));
                            }
                        }
                    }
                    sqlConnection.Close();
                }                                 

            }
            return descripciones;          
        }

        public List<string> GetTodasLasDescripcionesConAdapter()
        {
            List<string> descripciones = new List<string>();
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("SELECT * FROM Producto", sqlConnection);

                sqlConnection.Open();
                DataSet resultado = new DataSet();
                sqlDataAdapter.Fill(resultado);

                sqlConnection.Close();
            }

            return descripciones;

        }

        public void BorrarUnProducto(int idProducto)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryDelete = "DELETE FROM Producto WHERE Id = @idProducto";

                SqlParameter sqlParameter = new SqlParameter("idProducto", SqlDbType.BigInt);
                sqlParameter.Value = idProducto;
                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryDelete, sqlConnection))
                {
                    sqlCommand.Parameters.Add(sqlParameter);
                    sqlCommand.ExecuteScalar();
                }

                sqlConnection.Close();
            }
        }

        public void AgregarProducto(Producto producto)
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryInsert = "INSERT FROM Producto (Descripciones, Costo, PrecioVenta, Stock, IdUsuario)" +
                    "VALUES (@Descripciones, @Costo, @PrecioVenta, @Stock, @IdUsuario)";

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryInsert, sqlConnection))
                {

                    sqlCommand.Parameters.Add(new SqlParameter("Descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                    sqlCommand.Parameters.Add(new SqlParameter("Costo", SqlDbType.Int) { Value = producto.Costo });
                    sqlCommand.Parameters.Add(new SqlParameter("PrecioVenta", SqlDbType.Int) { Value = producto.PrecioDeVenta });
                    sqlCommand.Parameters.Add(new SqlParameter("Stock", SqlDbType.Int) { Value = producto.Stock });
                    sqlCommand.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = producto.IdUsuario });

                    sqlCommand.ExecuteNonQuery();// Aca viene el Insert, segun la IA sirve mas el executeNonQuery ya que no devuelve nada
                }
                sqlConnection.Close();
            }
        }



        public void ActualizarProducto(Producto producto)/// nose si funciona esto
        {
            using (SqlConnection sqlConnection = new SqlConnection(ConnectionString))
            {
                string queryUpdate = "UPDATE Producto " +
                    "SET Descripciones = @descripciones" +
                    "precioCompra = @precioCompra" +
                    "precioVenta = @precioVenta" +
                    "categoria = @categoria" +
                    "WHERE Id = @Id ";

                sqlConnection.Open();

                using (SqlCommand sqlCommand = new SqlCommand(queryUpdate, sqlConnection))
                {

                    sqlCommand.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = producto.Id });
                    sqlCommand.Parameters.Add(new SqlParameter("descripciones", SqlDbType.VarChar) { Value = producto.Descripciones });
                    sqlCommand.Parameters.Add(new SqlParameter("precioCompra", SqlDbType.BigInt) { Value = producto.PrecioDeCompra });
                    sqlCommand.Parameters.Add(new SqlParameter("precioVenta", SqlDbType.BigInt) { Value = producto.PrecioDeVenta });
                    sqlCommand.Parameters.Add(new SqlParameter("categoria", SqlDbType.VarChar) { Value = producto.Categoria });

                    sqlCommand.ExecuteNonQuery();// Aca viene el Insert, segun la IA sirve mas el executeNonQuery ya que no devuelve nada
                }
                sqlConnection.Close();
            }
        }

    }

}

