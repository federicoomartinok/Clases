namespace EjemploDeClase
{
    class ProbarObjetos
    {
        static void Main( string[] args)
        {
      
            Producto producto = new Producto();

            Console.WriteLine(producto.Categoria);

            producto.Categoria = "Cervezas";

            Console.WriteLine(producto.Categoria);

            
        }
    }
    
    public class Producto
    {
        private int _codigo;
        public int Codigo
        {
            get
            {
                return this._codigo;
            }
            set
            {
                this._codigo = value;
            }
        }
        private string _descripcion;
        private string Descripion
        {
            get
            {
                return this._descripcion;
            }
            set
            {
                this._descripcion = value;
            }
        }

        private string _categoria;

        public string Categoria
        {
            get
            {
                if (!String.IsNullOrEmpty(this._categoria))
                {
                    return this._categoria;
                }
                else
                {
                    return "No tiene categoria";
                }                
            }
            set
            {
                this._categoria = value;
            }
        }

        private double _precioDeCompra;
        private double _precioDeVenta;

        /*public Producto() ///constructor comun
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

        public int obetenerId()
        {
            int id = 1;
            id += 1;
            _codigo = id;

            return _codigo;
        }*/

 
    }

   
}
