using LicenciasAPI;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]
public class LicenciasController : ControllerBase
{
    // Endpoint GET api/licencias
    [HttpGet]
    public IActionResult Get()
    {
        // Lógica para obtener todas las licencias
        return Ok("Lista de licencias");
    }

    // Endpoint GET api/licencias/{id}
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        // Lógica para obtener una licencia por su ID
        return Ok("Licencia con ID " + id);
    }

    // Endpoint POST api/licencias
    [HttpPost]
    public IActionResult Post([FromBody] Licencia licencia)
    {
        // Lógica para crear una nueva licencia
        return Created("", licencia);
    }

    // Endpoint PUT api/licencias/{id}
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Licencia licencia)
    {
        // Lógica para actualizar una licencia existente
        return Ok("Licencia actualizada con ID " + id);
    }

    // Endpoint DELETE api/licencias/{id}
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        // Lógica para eliminar una licencia existente
        return NoContent();
    }
}
