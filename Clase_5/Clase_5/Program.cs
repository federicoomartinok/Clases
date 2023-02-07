namespace EjemploDeClase
{
    class ProbarObjetos
    {
        static void Main( string[] args)
        {
            static int generateId()
            {
                int id = 1;   //This resets the value to 1 every time you enter.
                return id += 1;
            }

            Producto prod = new Producto();
            Producto producto = new Producto();
            producto._codigo = generateId();

            Console.WriteLine("El codigo es: " + producto._codigo);
            
        }
    }
    
    public class Producto
    {
        public int _codigo;
        public string _descripion;
        public string _categoria;
        public double _precioDeCompra;
        public double _precioDeVenta;

        public Producto() ///constructor comun
        {
            _codigo = 0;
            _descripion = String.Empty;
            _categoria = String.Empty;
            _precioDeCompra = 0;
            _precioDeVenta = 0;
        }

        public Producto(int codigo, string descripcion, string categoria, double precioDeCompra, double precioDeVenta) /// constructor parametrizado
        {
            this._codigo = codigo;
            this._descripion = descripcion;
            this._categoria = categoria;
            this._precioDeCompra = precioDeCompra;
            this._precioDeVenta = precioDeVenta;
        }
    }

   
}
