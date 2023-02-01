// See https://aka.ms/new-console-template for more information

/*
string nombre;
string apellido;
string input;
int dni;
int edad;
float altura;

Console.WriteLine("Ingrese el nombre: ");
nombre = Console.ReadLine();
Console.WriteLine("Ingrese su apellido: ");
apellido = Console.ReadLine();
Console.WriteLine("Ingrese su edad: ");
input = Console.ReadLine();
edad = Convert.ToInt32(input);
Console.WriteLine("Ingrese su dni sin puntos ni comas: ");
input = Console.ReadLine();
dni = Convert.ToInt32(input);
Console.WriteLine("Ingrese su altura: ");
input = Console.ReadLine();
altura = float.Parse(input);


Console.WriteLine("Nombre: " + nombre + "\nApellido: " + apellido + " \nEdad: " + edad + " \nDni: " + dni + " \nAltura: " + altura );*/

string input;
int numero1;
int numero2;
int suma;

Console.WriteLine("Ingrese el primer numero: ");
input = Console.ReadLine();
numero1 = Convert.ToInt32(input);
Console.WriteLine("Ingrese el segundo numero: ");
input = Console.ReadLine();
numero2 = Convert.ToInt32(input);

suma = numero1 + numero2;

Console.WriteLine("La suma de: "+numero1 + "+" + numero2+ " es: " + suma);

