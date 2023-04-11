using Microsoft.AspNetCore.Mvc;
using MiPrimerApi.Model;
using MiPrimerApi.Repository;

namespace MiPrimerApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios")]
        public List <Usuario> GetUsuarios()
        {
            return UsuarioHandler.GetUsuarios();
        }
    }
}
