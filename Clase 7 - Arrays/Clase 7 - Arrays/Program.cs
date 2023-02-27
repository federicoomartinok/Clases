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

            ciudadesXpaises.Add("Bogota", "Colombia");
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
