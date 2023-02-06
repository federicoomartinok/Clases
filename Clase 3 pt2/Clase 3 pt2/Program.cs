// See https://aka.ms/new-console-template for more information
/*
double nota;
double sumaDeNotas = 0;
int cantidadDeNotas;
int i;

Console.WriteLine("Ingrese la cantidad de notas que desea cargar: ");
cantidadDeNotas = int.Parse(Console.ReadLine());

for(i=0; i<cantidadDeNotas; i++)
{
    Console.WriteLine("Ingrese la nota: ");
    nota = double.Parse(Console.ReadLine());
    sumaDeNotas = nota + sumaDeNotas;
}

Console.WriteLine("La suma de las notas es: {0}",sumaDeNotas);
*/

//string contraseña = string.Empty;
//string contraseñaCorrecta = "fede123";
//int tries = 3;
//bool login = false;

//Console.WriteLine("Ingrese la contraseña: ");
//contraseña = Console.ReadLine();

//while(login is false)
//{
//    if(tries == 5)
//    {
//        Console.WriteLine("Usted supero la cantidad de intentos");
//        break;
//    }
//    if (contraseña.Equals(contraseñaCorrecta))
//    {
//        Console.WriteLine("Bienvenido a la aplicacion.");
//        login = true;
//    }
//    else
//    {
//        Console.WriteLine("ERROR!, usted ingreso mal la contraseña, reingresela: ");
//        contraseña = Console.ReadLine();
//    }
//    tries++;
//}


//Console.WriteLine("Ingrese la contraseña: ");
//contraseña = Console.ReadLine();

//for (int i = 0; i < tries; i++)
//{
//    if (contraseña.Equals(contraseñaCorrecta))
//    {
//        login = true;
//        break;
//    }
//    else
//    {
//        Console.WriteLine("ERROR!, usted ingreso mal la contraseña, reingresela: ");
//        contraseña = Console.ReadLine();
//    }
//}

//if (login)
//{
//    Console.WriteLine("Bienvenido a la app.");
//}
//else
//{
//    Console.WriteLine("Usted supero los reintentos.");
//}



/// Hacer funciones y que devuelva **** es correcta



//string password = "fede12345678";
//string inputPassword = string.Empty;
//string mensaje;

//login();



//void login()
//{
//    bool loginExitoso = false;
//    int tries = 0;

//    do
//    {
//        Console.WriteLine("Ingrese la password: ");
//        inputPassword = Console.ReadLine();

//        if (inputPassword.Equals(password))
//        {
//            loginExitoso = true;
//        }
//        else
//        {
//            Console.WriteLine("Error, password erronea!.");
//        }
//        tries++;
//        if(tries > 1)
//        {
//            break;
//        }


//    } while (loginExitoso is false);
//    if (loginExitoso)
//    {
//        string mensaje = ContadorDeCaracteres();
//        Console.WriteLine(mensaje + " Es correcta");
//    }
//    else
//    {
//        Console.WriteLine("Ud supero los intentos, debe cambiar la password.");
//    }
//}

//string ContadorDeCaracteres()
//{
//    string resultado = string.Empty;
//    for (int i = 1; i < password.Length; i++)
//    {
//        resultado += "*";
//    }
//    return resultado;
//}



/*
 DES DESODORANTE 200
JP JABON EN POLVO 300
DET DETERGENTE 250
HACER UN MENU CON ESO Y CUANDO PONGAN FIN DIGA EL MONTO A ABONAR*/


int desodorante = 200;
int jabonPolvo = 300;
int detergente = 250;
int cantidad;
int contadorDesodorante = 0;
int contadorJp = 0;
int contadorDetergente = 0;
string input = string.Empty;

double suma;
bool salir = false;

do
{
    menu();
    input = Console.ReadLine();   
    
    switch (input.ToUpper())
    {
        case "DES":
            Console.WriteLine("Seleccione la cantidad de DESODORANTES: ");
            cantidad = int.Parse(Console.ReadLine());
            contadorDesodorante+=cantidad;
            break;
        case "JP":
            Console.WriteLine("Seleccione la cantidad de JABONES EN POLVO: ");
            cantidad = int.Parse(Console.ReadLine());
            contadorJp+=cantidad;
            break;
        case "DET":
            Console.WriteLine("Seleccione la cantidad de DETERGENTES: ");
            cantidad = int.Parse(Console.ReadLine());
            contadorDetergente+=cantidad;
            break;
        case "FIN":
            suma = sumaTotal();
            Console.WriteLine("El monto a abonar es {0} si desea confirmar la compra precione CONF", suma);
            break;
        case "CONF":
            Console.WriteLine("~~~GRACIAS POR USAR NUESTRA TIENDA~~~");
            salir = true;
            break;
    }

}while (salir is false);

void menu()
{
    Console.WriteLine("Bienvenido al menu del Supermecado");
    Console.WriteLine("Ingrese DES para comprar un desodorante--->200$");
    Console.WriteLine("Ingrese JP para comprar un Jabon en Polvo--->300$");
    Console.WriteLine("Ingrese DET para comprar un Detergente--->250$");
    Console.WriteLine("Ingrese FIN ver el monto de su compra");
    Console.WriteLine("Ingrese CONF para confirmar su compra");
}

double sumaTotal()
{
    double total;
    total = (contadorDesodorante * 200 + contadorDetergente * 250 + contadorJp * 300);

    return total;
}










