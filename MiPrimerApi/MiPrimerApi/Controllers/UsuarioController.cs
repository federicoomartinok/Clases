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
        [HttpGet(Name = "GetUsuarios")]
        public List<Usuario> GetUsuarios()
        {
            return UsuarioHandler.GetUsuarios();
        }

        [HttpDelete]
        public void EliminarUsuario([FromBody] int id)
        {

        }
        [HttpPut]
        public void ModificarUsuario([FromBody] PutUsuario usuario)
        {

        }
        [HttpPost]
        public void CrearUsuario([FromBody] PostUsuario usuario)
        {

        }


    }
}
