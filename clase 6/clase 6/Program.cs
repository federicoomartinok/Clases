namespace Ejemplos
{
    class ProbandoMain
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("123465",39959605,"Federico","Avenida Brasil");
            Estudiante estudiante = new Estudiante("Programacion",45698563,"Javier","La Esquina");

            Persona persona = new Persona();

            ///empleado.MostrarDatos();   
                       
        }
    }
  
    public class Persona
    {
        protected long dni;
        protected string nombre;
        protected string domicilio;

        public Persona()
        {
            this.dni = 0;
            this.nombre = String.Empty;
            this.domicilio = String.Empty;
        }

        public Persona(long dni, string nombre, string domicilio)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.domicilio = domicilio;
        }

        /// <summary>
        /// Virtual es para que despues podamos usarla en otra clase heredada
        /// </summary>
        public virtual void MostrarDatos()
        {
            Console.WriteLine("Dni: " + dni + " Nombre: " + nombre + " Domicilio: " + domicilio);
        }

    }

    class Empleado : Persona
    {
        protected string legajo;
        public Empleado(string legajo, long dni, string nombre, string domicilio)
            : base(dni, nombre, domicilio)
        {
            this.legajo = legajo;
        }


        /// <summary>
        /// override es para modificar y agregar algun datos en el metodo de la clase padre
        /// </summary>
        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine("Legajo: " + legajo);
        }
    }

    class Estudiante : Persona
    {
        protected string carrera;

        public Estudiante(string carrera, long dni, string nombre, string domicilio)
            : base(dni, nombre, domicilio)
        {
            this.carrera = carrera;
        }

    }
        
}
