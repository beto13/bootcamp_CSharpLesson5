var nombre = "";
var email = "";
var cupon = "";
double descuento = 0.10;
double precio = 10.50;

Console.WriteLine("Por favor ingrese su nombre...");
nombre = Console.ReadLine();

Console.WriteLine("Por favor ingrese su email...");
email = Console.ReadLine();

Console.WriteLine("Posee un cupon de descuento? Ingrese el codigo");
cupon = Console.ReadLine();

if (cupon.ToUpper() == "S")
{
    precio = precio - (precio * descuento);
    Console.WriteLine("Precio producto con descuento: {0}", precio);    
}
else
{
    Console.WriteLine("Precio producto sin descuento: {0}", precio);
}
Console.ReadKey();