using Microsoft.AspNetCore.Mvc;
using MiPrimerApi.Model;

namespace MiPrimerApi.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet(Name = "GetUsuarios")]
        public List <Usuario> GetUsuarios()
        {
            return new List<Usuario>();
        }
    }
}
