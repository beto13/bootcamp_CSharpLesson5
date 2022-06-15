var input = "";

Console.WriteLine("1. JavaScript");
Console.WriteLine("2. C++");
Console.WriteLine("3. JAVA");
Console.WriteLine("4. C#");
Console.WriteLine("5. PYTHON");

Console.WriteLine();
Console.WriteLine("Por favor ingrese una opcion...");
input = Console.ReadLine();

switch (input.ToUpper())
{
    case "1":
        Console.WriteLine("LENGUAJE SELLECCIONADO: JavaScript");
        break;
    case "2":
        Console.WriteLine("LENGUAJE SELLECCIONADO: C++");
        break;
    case "3":
        Console.WriteLine("LENGUAJE SELLECCIONADO: JAVA");
        break;
    case "4":
        Console.WriteLine("LENGUAJE SELLECCIONADO: C#");
        break;
    case "5":
        Console.WriteLine("LENGUAJE SELLECCIONADO: PYTHON");
        break;
    default:
        Console.WriteLine("Opcion incorrecta...");
        break;
}
Console.ReadKey();      