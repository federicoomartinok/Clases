using Microsoft.EntityFrameworkCore;

namespace LicenciasAPI
{
    public class LicenciasDbContext : DbContext
{
        public DbSet<Licencia> Licencias { get; set; }

        public LicenciasDbContext() : base("name=LicenciasConnectionString")
        {
            public const string ConnectionString = "Server = 10.108.30.15; Database=[SistemaGestion];UID=testuser;PWD=qwertu";
        }
    }
}
