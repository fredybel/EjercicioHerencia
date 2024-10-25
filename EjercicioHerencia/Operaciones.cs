
namespace EjercicioHerencia
{
    public abstract class Operaciones
    {
        public abstract double Area();
        public abstract double Longitud();
        public abstract double Volumen();
        public void Imprimir() 
        {
            Console.WriteLine($"Area: {Area()}");
            Console.WriteLine($"Longitud: {Longitud()}");
            Console.WriteLine($"Volumen: {Volumen()}");

        }
    }
}