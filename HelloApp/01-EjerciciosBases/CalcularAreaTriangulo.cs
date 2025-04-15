partial class Program
{
    static void AreaTriangulo()
    {
        Console.WriteLine("Calculadora para sacar el area de un triangulo");

        Console.WriteLine("Ingrese la base del triangulo");
        double numberBase = double.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese la altura del triangulo");
        double numberHeight = double.Parse(Console.ReadLine()!);

        double result = numberBase * numberHeight / 2;

        Console.WriteLine($"El area del triangulo es: {result}");
    }
}