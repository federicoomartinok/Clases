using System.Web.Http;
using Microsoft.EntityFrameworkCore;

namespace LicenciasAPI.Controllers
{
    public class LicenciasController : ApiController
    {
        private LicenciasDbContext _db = new LicenciasDbContext();

        // POST api/licencias
        [HttpPost]
        public IHttpActionResult PostLicencia(Licencia licencia)
        {
            _db.Licencias.Add(licencia);
            _db.SaveChanges();
            return Ok();
        }

        // GET api/licencias/{id}
        [HttpGet]
        public IHttpActionResult GetLicencia(int id)
        {
            var licencia = _db.Licencias.Find(id);
            if (licencia == null)
            {
                return NotFound();
            }
            return Ok(licencia);
        }

        // PUT api/licencias/{id}
        [HttpPut]
        public IHttpActionResult PutLicencia(int id, Licencia licencia)
        {
            if (id != licencia.Id)
            {
                return BadRequest();
            }
            _db.Entry(licencia).State = EntityState.Modified;
            _db.SaveChanges();
            return Ok();
        }

        // DELETE api/licencias/{id}
        [HttpDelete]
        public IHttpActionResult DeleteLicencia(int id)
        {
            var licencia = _db.Licencias.Find(id);
            if (licencia == null)
            {
                return NotFound();
            }
            _db.Licencias.Remove(licencia);
            _db.SaveChanges();
            return Ok();
        }
    }
}
