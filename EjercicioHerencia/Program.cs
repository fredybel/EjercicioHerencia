using EjercicioHerencia;

Calculos calculos = new Calculos();
int opcion;

Console.WriteLine("****************************************");
Console.WriteLine("*                  MENU                *");
Console.WriteLine("* 1. Calcular Area                     *");
Console.WriteLine("* 2. Calcular Millas a Kms             *");
Console.WriteLine("* 3. Calcular Volumen de un cilindro   *");
Console.WriteLine("***************************");
Console.WriteLine("Escoja la opción:");
opcion = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();
switch (opcion)
{
    case 1:
        Console.WriteLine("Escriba el Radio: ");
        calculos.Radio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-----------------------------------------");
        calculos.Imprimir();
        break;

    case 2:

        Console.WriteLine("Escriba las millas: ");
        calculos.Millas  = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-----------------------------------------");
        calculos.Imprimir();
        break;

    case 3:

        Console.WriteLine("Escriba el Radio: ");
        calculos.Radio = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Escriba la altura");
        calculos.Altura = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-----------------------------------------");
        calculos.Imprimir();
        break;

    default:
        Console.WriteLine("ADIOS");
        break;
}