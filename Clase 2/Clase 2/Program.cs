// See https://aka.ms/new-console-template for more information
/*control stock basico productos en un deposito, cant de prod y vendidos. si no existen prod en 
deposito entonces debemos reponer*/
/* -------------------------------------
 * EJEMPLO DE STOCKS
int cantidadProductosStock;
int productosVendidos;
int stock;

Console.WriteLine("Ingrese la cantidad de productos en stock: ");
cantidadProductosStock = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese la cantidad de productos vendidos: ");
productosVendidos= Convert.ToInt32(Console.ReadLine());

stock = cantidadProductosStock - productosVendidos;

if(stock == 0)
{
    Console.WriteLine("Usted debe reponer productos");
}
else
{
    Console.WriteLine("A usted le quedan: {0} productos para vender",stock);
}

----------------------------------------------------------------------------------
EJEMPLO DE LICORERIA CON EDADES
short edad;
float gradoAlcoholicoBebida;

Console.WriteLine("~~~Bienvenido a la licoreria virtual~~~");
Console.WriteLine("Ingrese su edad: ");

edad = short.Parse(Console.ReadLine());

if (edad < 18)
{
    Console.WriteLine("Prohibida la venta de alcohol a menores de 18 años");
}
else
{
    Console.WriteLine("Ingrese el grado de alcohol de la bebida: ");
    gradoAlcoholicoBebida= float.Parse(Console.ReadLine());
    if(gradoAlcoholicoBebida > 21.5)
    {
        Console.WriteLine("Le recomendamos que prueba nuestra bebidas blancas");
    }
    else if(gradoAlcoholicoBebida > 14 && gradoAlcoholicoBebida <= 21.5)
    {
        Console.WriteLine("Le recomendamos que pruebe nuestors licores");
    }
    else
    {
        Console.WriteLine("Le recomendamos que pruebe nuestros vinos");
    }
}
*/
const int storePassword = 12345678;

Console.WriteLine("Validando acceso");
Console.WriteLine("Por favor ingrese su contraseña: ");
int password = Convert.ToInt32(Console.ReadLine());

if (password != storePassword)
{
    Console.WriteLine("Por favor re-ingrese su contraseña: ");
    password = Convert.ToInt32(Console.ReadLine());
}
else
{
    Console.WriteLine("Bienvenido al programa!!");
}
