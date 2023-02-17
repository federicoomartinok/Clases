namespace Ejercicios
{
    class Program
    {
        public static void Main(string[] args)
        {
            Auto autoFord = new ("MMMM", "blanco", 300, "Ford", "Camaro");
            Moto motoBmw = new ("MX123","Rojo",270,"Bmw","F600");

            Console.WriteLine("------------AUTO------------");

            Console.WriteLine(autoFord.ToString());
            autoFord.Arrancar();
            autoFord.Acelerar();
            autoFord.Acelerar();
            autoFord.Acelerar();
            autoFord.Detener();
            Console.WriteLine("------------Moto------------");

            Console.WriteLine(motoBmw.ToString());
            motoBmw.Arrancar();
            motoBmw.Acelerar();
            motoBmw.Acelerar();
            motoBmw.Acelerar();
            motoBmw.Detener();
        }

        interface IVehiculo
        {
            public void Arrancar();
            public void Detener();
            public void Acelerar();
        }


        public abstract class Vehiculo
        {
            public string numeroSerie { get; set; }
            public string color { get; set; }
            public float velocidadMaxima { get; set; }
            public string marca { get; set; }
            public string modelo { get; set; }
            protected float velocidadActual { get; set; }

            public Vehiculo(string numeroSerie, string color, float velocidadMaxima, string marca
                , string modelo)
            {
                this.numeroSerie = numeroSerie;
                this.color = color;
                this.velocidadMaxima = velocidadMaxima;
                this.marca = marca;
                this.modelo = modelo;
            }

            public override string ToString()
            {
                return "Numero de serie:" + this.numeroSerie + "\nColor: " + this.color +
                    "\nVelocidad Maxima: " + this.velocidadMaxima + "\nMarca: " + this.marca +
                    "\nModelo: " + this.modelo;
            }
        }

        class Moto : Vehiculo, IVehiculo
        {
            public Moto(string numeroSerie, string color, float velocidadMaxima, string marca, string modelo)
                : base(numeroSerie, color, velocidadMaxima, marca, modelo)
            {
            }
            public void Acelerar()
            {
                this.velocidadActual += 5;
                Console.WriteLine("Acelerando Moto a: {0} Km/h", this.velocidadActual);
            }

            public void Arrancar()
            {
                Console.WriteLine("Arrancando Moto....En Arranque");
            }

            public void Detener()
            {
                Console.WriteLine("Deteniendo la Moto.... Detenida");
            }

        }

        class Auto : Vehiculo, IVehiculo
        {
            public Auto(string numeroSerie, string color, float velocidadMaxima, string marca,
                string modelo)
                : base(numeroSerie, color, velocidadMaxima, marca, modelo)
            {
            }

            public void Acelerar()
            {
                this.velocidadActual += 10;
                Console.WriteLine("Acelerando Auto a: {0} Km/h", this.velocidadActual);
            }
            public void Arrancar()
            {
                Console.WriteLine("Arrancando Auto....En Arranque");
            }

            public void Detener()
            {
                Console.WriteLine("Deteniendo El Auto.... Detenido");
            }
        }

    }

}
