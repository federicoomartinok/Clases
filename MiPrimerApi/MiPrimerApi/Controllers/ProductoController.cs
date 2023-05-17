using Microsoft.AspNetCore.Mvc;
using MiPrimerApi.Controllers.DTOS;
using MiPrimerApi.Model;
using MiPrimerApi.Repository;


namespace MiPrimerApi.Controllers

{
    [ApiController]
    [Route("[controller]")]

    public class ProductoController : ControllerBase
    {
        [HttpGet("GetProductos")]

        public List<Producto> GetProductos()
        {
            return ProductoHandler.GetProductos();
        }

        [HttpDelete("BorrarProductos")]
        public bool EliminarProducto([FromBody] int id)
        {
            return ProductoHandler.EliminarProducto(id);
        }


        [HttpPut("ModificarNombreProducto")]
        public bool ModificarProducto([FromBody] PutProducto producto)
        {
            return ProductoHandler.ModificarNombreDeProducto(new Producto
            {
                Id = producto.Id,
                Descripciones = producto.Descripciones,
            });

        }

        [HttpPost("CrearProducto")]
        public bool CrearProducto([FromBody] PostProducto producto)
        {
            try
            {
                return ProductoHandler.CrearProducto(new Producto
                {
                    Descripciones = producto.Descripciones,
                    Costo = producto.Costo,
                    PrecioDeVenta = producto.PrecioDeVenta,
                    Stock = producto.Stock,
                    IdUsuario = producto.IdUsuario
                });

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }


    }
}
