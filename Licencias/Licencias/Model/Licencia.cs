namespace LicenciasAPI

{
    public class Licencia
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
    }
}

