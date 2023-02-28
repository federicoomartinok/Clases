namespace EjemplodeClase
{
    public class ProbarMain
    {
        static void Main(string[] args)
        {
            /*string[] razaDePerros = new string[5];
            string[] razaPerrosArray = { "Buldog","Pequines","Pastor Aleman","Salchicha",
            "Caniche"};

            razaDePerros[0] = "Buldog";
            razaDePerros[1] = "Pequines";
            razaDePerros[2] = "Pastor Aleman";
            razaDePerros[3] = "Salchicha";
            razaDePerros[4] = "Caniche";

            for (int i = 0; i< razaPerrosArray.Length; i++)
            {
                Console.WriteLine(razaPerrosArray[i]);
            }*/



            /*Producto[] bebidasGaseosas =
            {
            new Producto(1,"Coca - Cola",300, 350, "Gaseosa"),
            new Producto(2, "7up", 200, 450, "Gaseosa"),
            new Producto(3, "Manaos", 400, 650, "Gaseosa"),
            new Producto(4, "Paso de los Toros", 500, 750, "Gaseosa"),
            };


            Producto bebidaMasCara = new Producto();//creo un nuevo producto

            foreach(Producto bebida in bebidasGaseosas) //recorro todas las bebidas
            {
                if (bebida.PrecioDeCompra > bebidaMasCara.PrecioDeCompra) //comparo el precio 
                {
                    bebidaMasCara = bebida;
                }

            }

            Console.WriteLine("La bebida mas cara es: {0}", bebidaMasCara.Descripcion);*/

            ///ejemplo de diccionario

            Dictionary<string, string> ciudadesXpaises = new Dictionary<string, string>();

            ///la key es la ciudad y el value el pais

            /*ciudadesXpaises.Add("Bogota", "Colombia");
            ciudadesXpaises.Add("Lima", "Bolivia");
            ciudadesXpaises.Add("Buenos Aires", "Argentina");
            ciudadesXpaises.Add("Asuncion", "Paraguay");

            Console.WriteLine("Las ciudades por paises son:");

            foreach (KeyValuePair<string, string> ciudadYpais in ciudadesXpaises)
            {
                Console.WriteLine("{0} - {1}", ciudadYpais.Key, ciudadYpais.Value);
            }


            ciudadesXpaises.Remove("Buenos Aires");

            ciudadesXpaises["Lima"] = "Peru";

            Console.WriteLine("Las ciudades por paises nueva lista:");

            foreach (KeyValuePair<string, string> ciudadYpais in ciudadesXpaises)
            {
                Console.WriteLine("{0} - {1}", ciudadYpais.Key, ciudadYpais.Value);
            }*/

            ///diccionario dentro de otro diccionario
            ///
            /*
            Dictionary<string, Dictionary<string, double>> catalogoPetShop =
                new Dictionary<string, Dictionary<string, double>>();

            catalogoPetShop.Add("Alimento para Gatos Adultos", new Dictionary<string, double>
            {
                {"Cat Chow", 90 },
                {"Whiskas ", 85 },
                {"Pedigree", 95}
            });
            catalogoPetShop.Add("Alimento para Gatos Cachorro", new Dictionary<string, double>
            {
                {"Cat Chow", 88 },
                {"Whiskas ", 83 },
                {"Pedigree", 93}
            });


            catalogoPetShop.Add("Alimento para Perros Adultos", new Dictionary<string, double>
            {
                {"Dog Chow", 105 },
                {"Proplan ", 83 },
                {"Pedigree", 99}
            });

            catalogoPetShop.Add("Alimento para Perros Cachorros", new Dictionary<string, double>
            {
                {"Dog Chow", 96 },
                {"Proplan ", 101 },
                {"Pedigree", 33}
            });

            Console.WriteLine("Seccion\n \t\t\t\t\tProducto\t\tPrecio");
            foreach (KeyValuePair<string, Dictionary<string, double>> seccion in catalogoPetShop)
            {
                Console.WriteLine("{0}", seccion.Key);

                foreach (KeyValuePair<string, double> productoYprecio in seccion.Value)
                {
                    Console.WriteLine("\t\t\t\t\t{0}\t\t{1}", productoYprecio.Key, productoYprecio.Value);
                }

            }*/

            Dictionary<string, Dictionary<string, double>> menuRestaurante =
                new Dictionary<string, Dictionary<string, double>>();

            menuRestaurante.Add("Pastas", new Dictionary<string, double >
            {
                {"Tagliatelle", 90},
                {"Ñoquis   ", 85},
                {"Ravioles", 95}
            });
            menuRestaurante.Add("Carnes", new Dictionary<string, double>
            {
                {"Ojo de bife", 90},
                {"Ribs de cerdo", 85},
                {"T-Bone   ", 95}
            });
            menuRestaurante.Add("Pescados", new Dictionary<string, double>
            {
                {"Merluza  ", 90},
                {"Salmon   ", 85},
                {"Lenguado", 95}
            });

            Console.WriteLine("\t\t\t\t\tProducto\t\tPrecio");
            foreach (KeyValuePair<string, Dictionary<string, double>> seccion in menuRestaurante)
            {
                Console.WriteLine("{0}", seccion.Key);

                foreach (KeyValuePair<string, double> productoYprecio in seccion.Value)
                {
                    Console.WriteLine("\t\t\t\t\t{0}\t\t{1}", productoYprecio.Key, productoYprecio.Value);
                }

            }
        }
        public class Producto
        {
            public int Codigo;
            public string Descripcion;
            public double PrecioDeCompra;
            public double PrecioDeVenta;
            public string Categoria;


            public Producto()
            {
                Codigo = 0;
                Descripcion = String.Empty;
                PrecioDeCompra = 0;
                PrecioDeVenta = 0;
                Categoria = String.Empty;
            }

            public Producto (int codigo, string descripcion, double precioDeCompra, 
                double precioDeVenta, string categoria)
            {
                Codigo = codigo;
                Descripcion = descripcion;
                PrecioDeCompra = precioDeCompra;
                PrecioDeVenta = precioDeVenta;
                Categoria = categoria;
            }
        }
    }
}
