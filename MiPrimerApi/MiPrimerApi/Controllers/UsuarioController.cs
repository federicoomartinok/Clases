using Microsoft.AspNetCore.Mvc;
using MiPrimerApi.Controllers.DTOS;
using MiPrimerApi.Model;
using MiPrimerApi.Repository;

namespace MiPrimerApi.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("Get Usuarios")]
        public List<Usuario> GetUsuarios()
        {
            return UsuarioHandler.GetUsuarios();
        }

        [HttpDelete ("BorrarUsuario")]
        public bool EliminarUsuario([FromBody] int id)
        {
            return UsuarioHandler.EliminarUsuario(id);
        }
        [HttpPut ("ModificarNombreUsuario")]
        public bool ModificarUsuario([FromBody] PutUsuario usuario)
        {
            return UsuarioHandler.ModificarNombreDeUsuario(new Usuario
            {
                Id = usuario.Id,
                Nombre = usuario.Nombre,
            });

        }
        [HttpPost ("CrearUsuario")]
        public bool CrearUsuario([FromBody] PostUsuario usuario)
        {
            try
            {
                return UsuarioHandler.CrearUsuario(new Usuario
                {
                    Apellido = usuario.Apellido,
                    Contraseña = usuario.Contraseña,
                    Mail = usuario.Mail,
                    Nombre = usuario.Nombre,
                    NombreUsuario = usuario.NombreUsuario
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
