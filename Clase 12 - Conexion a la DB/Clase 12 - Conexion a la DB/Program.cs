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




    }

}

