namespace MiPrimerApi.Model
{
    public class Producto
    {
        public int Id { get; set; }
        public int Stock { get; set; }
        public int IdUsuario { get; set; }
        public int Costo { get; set; }
        public string Descripciones { get; set; }
        public double PrecioDeVenta { get; set; }

    }
}
