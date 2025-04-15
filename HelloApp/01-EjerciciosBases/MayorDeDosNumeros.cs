partial class Program
{
    static void MayorDeDosNumeros()
    {
        Console.WriteLine("Mayor de dos números");

        Console.WriteLine("Ingrese el primer número");
        int number1 = int.Parse(Console.ReadLine()!);

        Console.WriteLine("Ingrese el segundo número");
        int number2 = int.Parse(Console.ReadLine()!);

        if(number1 > number2)
        {
            Console.WriteLine("El primero numero es mayor que el segundo");
        }
        else if(number2 > number1)
        {
            Console.WriteLine("El segundo número es mayor que el primero");
        }
        else
        {
            Console.WriteLine("Lo dos números son iguales");
        }
    }
}