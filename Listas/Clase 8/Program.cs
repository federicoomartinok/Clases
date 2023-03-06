namespace claseOcho
{
    public class ProbarMain
    {
        static void Main(string[] args)
        {
            
        }

        public class Cliente//clase cliente 
        {
            public string Nombre;
            public long Id;
            public string Direccion;
            public short Edad;


            public Cliente(string nombre, long id, string direccion, short edad)//constructor parametrizado
            {
                Nombre = nombre;
                Id = id;
                Direccion = direccion;
                Edad = edad;
                
            }
        }

        public class ListasMayores ///Lista para ver metodos de las listas, como una linkedlist
        {
            public List<Cliente> _clientesMayores;

            public ListasMayores()
            {
                _clientesMayores = new List<Cliente>();
            }
        }
    }
}