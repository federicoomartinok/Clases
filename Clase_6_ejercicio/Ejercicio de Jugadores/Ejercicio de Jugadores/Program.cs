namespace ejercicioJugadores
{
    class ProbarMain
    {
        static void Main(string[] args)
        {

            int regate;       
            Console.Write("Ingrese con cuanto termino messi el regate: ");
            regate = int.Parse(Console.ReadLine());

            Messi messi = new Messi(regate, 88, 95, 30, 85, 60);
            CristianoRonaldo ronaldo = new CristianoRonaldo(99, 88, 98, 21, 83, 62);

            messi.Correr();
            messi.Rematar();
            messi.Regatear();
            messi.Defender();
            messi.Asistir();
            messi.Aguantar();
            Console.WriteLine("");
            ronaldo.Correr();
            ronaldo.Rematar();
            ronaldo.Regatear();
            ronaldo.Defender();
            ronaldo.Asistir();
            ronaldo.Aguantar();
        }

    
        interface IJugador
        {
            public void Correr();
            public void Rematar();
            public void Regatear();
            public void Defender();
            public void Asistir();
            public void Aguantar();

        }

        public abstract class Jugador
        {
            public int velocidad { get; set; }
            public int tiro { get; set; }
            public int regate { get; set; }
            public int defensa { get; set; }
            public int pase { get; set; }
            public int resistencia { get; set; }


            public Jugador(int velocidad, int tiro, int regate, int defensa, int pase, int resistencia)
            {
                this.velocidad = velocidad;
                this.tiro = tiro;
                this.regate = regate;
                this.defensa = defensa;
                this.pase = pase;
                this.resistencia = resistencia;
            }               

        }

        class Messi : Jugador, IJugador
        {
            public Messi(int velocidad, int tiro, int regate, int defensa, int pase, int resistencia)
                : base(velocidad,tiro,regate,defensa,pase,resistencia)
            {
            }

            public void Correr()
            {
                this.velocidad = velocidad;
                Console.WriteLine("Lionel Messi corrio con {0} de velocidad", this.velocidad);
            }

            public void Rematar()
            {
                this.tiro = tiro;
                Console.WriteLine("Lionel Messi remató con {0} de remate", this.tiro);

            }
            public void Regatear() 
            {
                this.regate = regate;
                Console.WriteLine("Lionel Messi regateó con {0} de regate", this.regate);
            }
            public void Defender()
            {
                this.defensa = defensa;
                Console.WriteLine("Lionel Messi defendio con {0} de defensa", this.defensa);
            }
            public void Asistir()
            {
                this.pase = pase;
                Console.WriteLine("Lionel Messi Asistio con {0}% de efectividad", this.pase);

            }
            public void Aguantar()
            {
                this.resistencia= resistencia;
                Console.WriteLine("Lionel Messi aguanto con {0} de resistencia", this.resistencia);

            }
        }

        class CristianoRonaldo : Jugador, IJugador
        {
            public CristianoRonaldo(int velocidad, int tiro, int regate, int defensa, int pase, int resistencia)
                : base(velocidad, tiro, regate, defensa, pase, resistencia)
            {
            }

            public void Correr()
            {
                this.velocidad = velocidad;
                Console.WriteLine("Cristiano Ronaldo corrio con {0} de velocidad", this.velocidad);
            }

            public void Rematar()
            {
                this.tiro = tiro;
                Console.WriteLine("Cristiano Ronaldo remató con {0} de remate", this.tiro);

            }
            public void Regatear()
            {
                this.regate = regate;
                Console.WriteLine("Cristiano Ronaldo regateó con {0} de regate", this.regate);
            }
            public void Defender()
            {
                this.defensa = defensa;
                Console.WriteLine("Cristiano Ronaldo defendio con {0} de defensa", this.defensa);
            }
            public void Asistir()
            {
                this.pase = pase;
                Console.WriteLine("Cristiano Ronaldo Asistio con {0}% de efectividad", this.pase);

            }
            public void Aguantar()
            {
                this.resistencia = resistencia;
                Console.WriteLine("Cristiano Ronaldo aguanto con {0} de resistencia", this.resistencia);

            }


        }

        
    }
}
