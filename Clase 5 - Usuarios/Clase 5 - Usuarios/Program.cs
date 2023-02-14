using System;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
namespace EjercicioUsuario
{
    public class Usuario
    {
        private string _nombre;
        private string _apellido;
        private string _email;
        private string _domicilio;
        private int _dni;
        private int _edad;

        public Usuario ()
        {
            _nombre = "Juan";
            _apellido = "Fernandez";
            _email = "Juan_Fernandez123@hotmail.com";
            _domicilio = "Ni idea 455";
            _dni = 45125123;
            _edad = 17;

        }

        public string DondeVive()
        {
            return _domicilio;
        }

        public int GetDni()
        {
            return _dni;
        }

        public string GetGmail()
        {
            return _email;
        }

        public void SetNewDomicilio(string nuevoDomicilio)
        {
            _domicilio = nuevoDomicilio;
        }

        public string EsMayorDeEdad()
        {
            if (_edad >= 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor de edad";
            }
            
        }     

    }

    class ProbarMain
    {
        static void Main (string[] args)
        {
            Usuario user = new Usuario();

            Console.WriteLine(user.DondeVive());

            user.SetNewDomicilio("Calle perro 444");

            Console.WriteLine(user.DondeVive());

            Console.WriteLine(user.EsMayorDeEdad());

            Console.WriteLine(EsGmail(user.GetGmail()));


        }
        public static string EsGmail(string email)
        {
            Regex emailRegex = new Regex(@"[a-zA-Z0-9]{0,}([.]?[a-zA-Z0-9]{1,})[@](gmail.com)", RegexOptions.IgnoreCase);
            if (emailRegex.IsMatch(email))
            {
                return "Es gmail";
            }
            else
            {
                return "No es gmail";
            }
            
        }


    }


}
    





