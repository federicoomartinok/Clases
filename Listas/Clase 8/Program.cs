namespace claseOcho
{
    public class ProbarMain
    {
        static void Main(string[] args)
        {
            ListasMayores mayores = new ListasMayores();
            Cliente[] clientes =
            {
                new Cliente("Fede",1,"San cristobal",26),
                new Cliente("Martin",2,"Calle loca",25),
                new Cliente("Ariel",3,"Av. Godines",22),
                new Cliente("Facu",4,"Eva peron",44)

            };

           mayores.InsertarEnLista(clientes);

            mayores.MostrarLista();

            
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


            public void InsertarEnLista(Cliente[] clientes)
            {
                Console.WriteLine($"Insertando en lista {clientes.Length} clientes");

                foreach (Cliente cliente in clientes)
                {
                    _clientesMayores.Add(cliente);
                }
            }

            public bool BorrarCliente(Cliente cliente)
            {
                bool seBorroElCliente = false;

                if (_clientesMayores.Contains(cliente))
                {
                    seBorroElCliente = _clientesMayores.Remove(cliente);
                }

                return seBorroElCliente;
            }

            public void MostrarLista()
            {
                foreach (Cliente cliente in _clientesMayores)
                {
                    Console.WriteLine($"Nombre: {cliente.Nombre} - ID: {cliente.Id} " +
                        $"-Direccion: {cliente.Direccion} - Edad: {cliente.Edad}");
                }
            }
        }
        
    }
}