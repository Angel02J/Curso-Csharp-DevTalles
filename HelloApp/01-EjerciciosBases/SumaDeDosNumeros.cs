partial class Program
{
    static void SumaDeNumeros()
    {
        //Crea un programa que pida al usuario dos números enteros y muestre su suma.

        Console.WriteLine("Calculadora para sumar dos números");

        Console.WriteLine("Ingrese el primer número");
        int number1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese el segundo número");
        int number2 = int.Parse(Console.ReadLine()!);

        int resultado = number1 + number2;

        Console.WriteLine($"El resultado es: {resultado}");
    }
}